using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NguyenHuy_Winform3.ADO;
using NguyenHuy_Winform3.StudentManage;

namespace NguyenHuy_Winform3
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {   
            if(string.IsNullOrEmpty(textBoxUser.Text)||string.IsNullOrEmpty(textBoxPassword.Text))
            {
                labelNofitication.Text = "user or password is not empty";
                return;
            }
            int i=-1;
            DataRowCollection dataRow = DBO.UserData.Tables[0].Rows;
            foreach (DataRow row in dataRow)
            {
                if(textBoxUser.Text ==row[1].ToString()&&textBoxPassword.Text==row[2].ToString()&&
                    row[3].ToString().Equals("teacher"))
                    {
                    DaskBoardForm daskBoardForm = new DaskBoardForm("Menu",row[0].ToString());
                    daskBoardForm.ShowDialog();
                    break;

                }
                else if (textBoxUser.Text == row[1].ToString() && textBoxPassword.Text == row[2].ToString() &&
                    row[3].ToString().Equals("admin"))
                {
                    DaskBoardForm daskBoardForm = new DaskBoardForm("","");
                    daskBoardForm.ShowDialog();
                    break;
                }
                else
                {
                    i = -1;
                }
                if (i == -1)
                {
                    labelNofitication.Text = "User or PassWord incorrect!";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxUser.Text = "";
            textBoxPassword.Text = "";
            labelNofitication.Text = "";
        }

    }
}
