using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UP_manager;

namespace UP_manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void Main_Load(object sender, EventArgs e)
        {
            {
                ubGridView.Rows.Clear();
                if (UP_manager.msSqlConnector.OpenSqlConnection())
                {
                    DataSet ds = msSqlConnector.SqlResultQuery("SELECT id, name, inn FROM up_data");
                    var ub_list = new DataTable();
                    ub_list = ds.Tables[0];
                    foreach (DataRow row in ub_list.Rows)
                    {
                        ubGridView.Rows.Add(row.ItemArray[0], row.ItemArray[1], row.ItemArray[2]);
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void AddNewUPmenu_Click(object sender, EventArgs e)
        {
            ubAddForm ubaf = new ubAddForm();
            ubaf.ShowDialog();
        }

        private void ChangeUpMenu_Click(object sender, EventArgs e)
        {
            string up_id = ubGridView.CurrentRow.Cells[0].Value.ToString();
            ubAddForm cgebaf = new ubAddForm(up_id);
            cgebaf.ShowDialog();
        }

        private void DellUpMenu_Click(object sender, EventArgs e)
        {
            string up_id = ubGridView.CurrentRow.Cells[0].Value.ToString();
            string sql = @"DELETE FROM up_data WHERE id=" + up_id;

            if (msSqlConnector.SqlNoResultQuery(sql))
            {
                MessageBox.Show("Успешно удалено!");
                this.Main_Load(sender, e);
            }
        }

        private void AllRegPFRmenu_Click(object sender, EventArgs e)
        {
            string up_id = ubGridView.CurrentRow.Cells[0].Value.ToString();
            pfrMassRegForm mpfr = new pfrMassRegForm(up_id);
            mpfr.ShowDialog();
        }
    }
}
