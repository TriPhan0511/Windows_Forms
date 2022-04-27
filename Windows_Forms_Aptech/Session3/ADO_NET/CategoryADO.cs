using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET
{
    class CategoryADO
    {
        private string connectionString = "server=localhost; database=Demo_DAO; integrated security = true";
        public DataTable getAll()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("select * from Categories", conn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();

                conn.Open();
                sqlCommand.ExecuteNonQuery();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);
                conn.Close();
                return dataTable;
            }
        }
        public int Insert(string[] cateName)
        {
            string queryString = "insert into Categories values(" + cateName[0] + ")";
            for (int i = 1; i < cateName.Length; i++)
            {
                string a = ", (" + cateName[i] + ")";
                queryString += a;
            }
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "insert into Categories values('HoangVL'),('ThuanTP'),('LocHH')";
            sqlCommand.Connection = conn;
            return sqlCommand.ExecuteNonQuery();
        }
    }
}
