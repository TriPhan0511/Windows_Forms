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
                    MessageBox.Show("Dang nhap thanh cong",
                        "Thong bao",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "Dang nhap  KHONG thanh cong",
                        "Thong bao",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show(
                    "Ban co muon thoat hay khong?", 
                    "Thong bao", 
                    MessageBoxButtons.OKCancel, 
                    MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
