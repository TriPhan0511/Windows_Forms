using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Connect_To_Database_Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn =
                new SqlConnection(@"Data Source=DESKTOP-FBHSS47;Initial Catalog=SinhVien_DB;Integrated Security=True");
            try
            {
                conn.Open();
                string taiKhoan = txtTaiKhoan.Text;
                string matKhau = txtMatKhau.Text;
                string query =
                    $"SELECT TaiKhoan, MatKhau FROM NguoiDung WHERE TaiKhoan = '{taiKhoan}' AND MatKhau = '{matKhau}'";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Dang nhap thanh cong");
                }
                else
                {
                    MessageBox.Show("Dang nhap KHONG thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Console.WriteLine(ex.Message);
                //MessageBox.Show("Loi ket noi");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
