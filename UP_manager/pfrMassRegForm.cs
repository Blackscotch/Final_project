using System;
using System.ComponentModel;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.IO.Compression;

namespace UP_manager
{
    public partial class pfrMassRegForm : Form
    {
        public pfrMassRegForm()
        {
            InitializeComponent();
        }

        private string UB_NAME;
        private X509Certificate CERT;


        public pfrMassRegForm(string ubid)
        {
            InitializeComponent();
            this.up_id = ubid;
        }

        private void pfrMassRegForm_Load(object sender, EventArgs e)
        {
            DataSet ds = msSqlConnector.SqlResultQuery("SELECT name, cert from up_data WHERE id=" + up_id);
            UB_NAME = ds.Tables[0].Rows[0].ItemArray[0].ToString().Trim();
            CERT = new X509Certificate((byte[])ds.Tables[0].Rows[0].ItemArray[1]);
            ubNameLabel.Text = UB_NAME;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private bool Check_PFR(string pfr)
        {
            Regex rg = new Regex(@"^056-0\d{2}-\d{6}");

            if (rg.IsMatch(pfr))
            { return true; }
            else
            { return false; }
        }

        private bool Check_code(string code)
        {
            Regex rg = new Regex(@"^056-0\d{2}");

            if (rg.IsMatch(code))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filename = openFileDialog1.FileName;
            pathBox.Text = filename;
            importGridView.Rows.Clear();
            listBox1.Items.Clear();

            Excel.Application excelapp = new Excel.Application();
            excelapp.Workbooks.Open(filename, Type.Missing);


            int i = 0;
            int j = 0;
            try
            {
                while (excelapp.Workbooks[1].Sheets[1].Cells[i + 1, 1].Value != null)
                {

                    string a = excelapp.Workbooks[1].Sheets[1].Cells[i + 1, 1].Value.ToString();
                    string b = excelapp.Workbooks[1].Sheets[1].Cells[i + 1, 2].Value.ToString();
                    string c = excelapp.Workbooks[1].Sheets[1].Cells[i + 1, 3].Value.ToString();
                    if (Check_PFR(a) && Check_code(c))
                    {
                        importGridView.Rows.Add();
                        importGridView.Rows[j].Cells[0].Value = a;
                        importGridView.Rows[j].Cells[1].Value = b;
                        importGridView.Rows[j].Cells[2].Value = c;
                        j++;

                    }
                    else
                    {
                        listBox1.Items.Add(String.Format("Запись пропущена: {0} {1} {2} ", a, b, c));

                    }
                    i++;
                }
            }
            catch
            {

            }

            excelapp.Workbooks.Close();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                MessageBox.Show("Не выбран файл!");
                return;
            }

            string home = Directory.GetCurrentDirectory();
            string savepath = String.Format(@"{0}/UP_OUT/{1}/{2}/", home, UB_NAME.Replace("\"", ""), DateTime.Now.ToString("yyyy-MM-dd-HHmmss"));
            string cardspath = savepath + @"/REGCARDS/";
            Directory.CreateDirectory(savepath);
            Directory.CreateDirectory(cardspath);
            string pfr_code, name, pfr_region;

            foreach (DataGridViewRow row in importGridView.Rows)
            {
                pfr_code = row.Cells[0].Value.ToString();
                name = row.Cells[1].Value.ToString();
                pfr_region = row.Cells[2].Value.ToString();

                RegCard.PfrRegCard_create(name, pfr_code, pfr_region, Convert.ToBase64String(CERT.GetRawCertData()), cardspath + pfr_code + '_' + pfr_region + ".xml");
                listBox1.Items.Add(String.Format("Абонент {0} {1} создана рег. карта!", pfr_code, name));

                string check_sql = "SELECT id FROM up_pfr WHERE pfr_code='" + pfr_code + "'";
                msSqlConnector.OpenSqlConnection();
                DataSet ds = msSqlConnector.SqlResultQuery(check_sql);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    msSqlConnector.SqlNoResultQuery(String.Format(@" INSERT INTO up_pfr (ub_id, pfr_code, name, pfr_region)
                                                                    VALUES ({0}, '{1}', '{2}', '{3}')", up_id, pfr_code, name, pfr_region));
                }
                else
                {
                    var abn_id = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                    msSqlConnector.SqlNoResultQuery(String.Format(@" UPDATE up_pfr SET ub_id={0}, name ='{1}', pfr_region = '{2}', pfr_code = '{3}' 
                                                                     WHERE id={4}", up_id, name, pfr_region, pfr_code, abn_id));

                }
            }

            string startPath = cardspath;
            string zipPath = savepath + "import_pfr.zip";
            File.Delete(zipPath);
            ZipFile.CreateFromDirectory(startPath, zipPath);

            MessageBox.Show(String.Format(@"Файлы регистрации созданы в {0}. Абоненты зарегистрированы.", savepath));
        }
    }
}
