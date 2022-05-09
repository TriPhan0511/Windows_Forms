using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NguyenHuy_Winform3.ADO
{
    internal class DAO
    {
        // private static SqlConnection _connection = new SqlConnection("server=localhost;database=student_demo;uid=sa;pwd=990110");
        //private static SqlConnection _connection=new SqlConnection("Data Source=.;Initial Catalog=student_demo;User ID=sa;Password=990110 ");
        private static SqlConnection _connection=new SqlConnection("Data Source =.; Initial Catalog = student_demo; Integrated Security = True");
        
        public DAO()
        {
        }

        public static SqlConnection Connection { get { return _connection; }
            private set { _connection = value; }

        }
        System.Data.DataSet dataset;
        public DataSet ExcuteQuery(string str)
        {
            DAO.Connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(str, DAO.Connection);
            dataset = new DataSet();
            adapter.Fill(dataset);
            dataset.Dispose();
            DAO.Connection.Close();
            return dataset;

        }
        public int ExcuteNonQuery(string str)
        {
            int r = 0;
            DAO.Connection.Open();
            SqlCommand sqlCommand = new SqlCommand(str, DAO.Connection);
            if (str.Contains("insert"))
            { r = sqlCommand.ExecuteNonQuery(); }
            if (str.Contains("update"))
            { r = sqlCommand.ExecuteNonQuery(); }
            else if (str.Contains("delete"))
            { r = sqlCommand.ExecuteNonQuery(); }
            sqlCommand.Dispose();
            DAO.Connection.Close();
            return r;
        }

    }
}

