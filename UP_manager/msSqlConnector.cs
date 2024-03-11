using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace UP_manager
{
    public static class msSqlConnector
    {
        private static SqlConnection CONNECTION = new SqlConnection();
        private static bool CONNECTED = false;
        public static bool OpenSqlConnection()
        {
            if (CONNECTED)
            {
                return true;
            }

            string connectionString = GetConnectionString();
            CONNECTION.ConnectionString = connectionString;
            try
            {
                CONNECTION.Open();
                CONNECTED = true;
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                CONNECTED = false;
                return false;
            }

        }

        public static void CloseSqlConnection()
        {
            CONNECTION.Close();
            CONNECTED = false;
        }

        static private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MsSql"].ConnectionString;
        }

        static public bool GetConnectionState()
        {
            return CONNECTED;
        }

        static public DataSet SqlResultQuery(string query)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adaptr = new SqlDataAdapter();

            cmd.CommandText = query;
            cmd.Connection = CONNECTION;

            adaptr.SelectCommand = cmd;
            DataSet dataset = new DataSet();
            adaptr.Fill(dataset);
            return dataset;


        }

        static public bool SqlNoResultQuery(string query)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adaptr = new SqlDataAdapter();

            cmd.CommandText = query;
            cmd.Connection = CONNECTION;
            adaptr.SelectCommand = cmd;
            DataSet dataset = new DataSet();
            adaptr.Fill(dataset);
            return true;


        }
        static public bool SqlNoResultQuery(string query, params SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adaptr = new SqlDataAdapter();

            cmd.CommandText = query;
            cmd.Connection = CONNECTION;
            foreach (SqlParameter param in parameters)
            {
                cmd.Parameters.Add(param);
            }

            adaptr.SelectCommand = cmd;
            DataSet dataset = new DataSet();
            adaptr.Fill(dataset);
            return true;


        }
    }
}
