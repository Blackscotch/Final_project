using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace UP_manager
{
    public partial class ubAddForm : Form
    {
        public X509Certificate CERT;

        public ubAddForm()
        {
            InitializeComponent();
        }

        public ubAddForm(string up_id)
        {
            InitializeComponent();
            this.up_id = up_id;
        }

        private bool Check()
        {
            if (nameTextBox.Text == "" ||
                innTextBox.Text == "" ||
                pfrTextBox.Text == "" ||
                okpoTextBox.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ubAddForm_Load(object sender, EventArgs e)
        {
            if (this.up_id == null)
            {
                return;
            }
            DataSet ds = msSqlConnector.SqlResultQuery("SELECT name, inn, pfr, okpo FROM up_data WHERE id=" + up_id);
            DataTable ub_data = ds.Tables[0];

            try{nameTextBox.Text = (string)ub_data.Rows[0].ItemArray[0].ToString().Trim();}
            catch{nameTextBox.Text = "";}
            try { innTextBox.Text = (string)ub_data.Rows[0].ItemArray[1].ToString().Trim(); }
            catch { innTextBox.Text = ""; }
            try { pfrTextBox.Text = (string)ub_data.Rows[0].ItemArray[2].ToString().Trim(); }
            catch { pfrTextBox.Text = ""; }
            try { okpoTextBox.Text = (string)ub_data.Rows[0].ItemArray[3].ToString().Trim(); }
            catch { okpoTextBox.Text = ""; }
            try
            {
                CERT = new X509Certificate((byte[])ub_data.Rows[0].ItemArray[5]);
                certInfoBox.Text = CERT.ToString(true);
            }
            catch{}
        }

        private void certOpenButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            certPathBox.Text = openFileDialog1.FileName;
            CERT = new X509Certificate(certPathBox.Text);
            certInfoBox.Text = CERT.ToString(true);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                MessageBox.Show("Ошибка! Не все поля заполнены!");
                return;

            }
            if (this.up_id == null)
            {
                string sql = String.Format(@"INSERT INTO up_data (name, inn, pfr, okpo, cert) VALUES (
                '{0}', '{1}', '{2}', '{3}', @cert)", nameTextBox.Text, innTextBox.Text, pfrTextBox.Text, okpoTextBox.Text);

                SqlParameter cert_param = new SqlParameter("@cert", SqlDbType.Image);

                try
                {
                    CERT = new X509Certificate(openFileDialog1.FileName);
                }
                catch
                {
                    MessageBox.Show("Не выбран файл сертификата!");
                    return;
                }

                cert_param.Value = CERT.GetRawCertData();
                if (msSqlConnector.SqlNoResultQuery(sql, cert_param))
                {
                    MessageBox.Show("Успешно сохранено!");
                }
                else
                {
                    MessageBox.Show("Ошибка! УП не был сохранен");
                }
            }
            else  
            {
                string sql = String.Format(@"UPDATE up_data  SET name='{0}', inn='{1}', pfr='{2}', okpo='{3}', cert=@cert
                             WHERE id={4}", nameTextBox.Text, innTextBox.Text, pfrTextBox.Text, okpoTextBox.Text, this.up_id);

                SqlParameter cert_param = new SqlParameter("@cert", SqlDbType.Image);
                cert_param.Value = CERT.GetRawCertData();

                if (msSqlConnector.SqlNoResultQuery(sql, cert_param))
                {
                    MessageBox.Show("Успешно сохранено!");
                }
                else
                {
                    MessageBox.Show("Ошибка! УБ не была сохранена");
                }
            }
        }
    }
}

