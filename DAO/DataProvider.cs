using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DataProvider
    {
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        private static SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=CSDL2;Integrated Security=True");

        public DataProvider()
        {
            
        }

        private void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                DataProvider.conn.Open();
            }
        }
        private void CloseConnection()
        {
            if (DataProvider.conn != null)
            {
                DataProvider.conn.Close();
            }
        }

        public DataTable GetDataTable(string query)
        {
            try
            {
                OpenConnection();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(query, conn);
                sqlda.Fill(dt);
                CloseConnection();
                return dt;
            }
            catch 
            {
                return null;
            }
        }

        public void ExecuteReader(string query)
        {
            try
            {
                OpenConnection();
                SqlCommand sqlcmd = new SqlCommand(query,conn);
                sqlcmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch
            {

            }
        }
        public string GetValue(string query)
        {
            string temp = null;
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand(query, conn);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
                temp = sqldr[0].ToString();
            CloseConnection();
            return temp;
        }
    }
}