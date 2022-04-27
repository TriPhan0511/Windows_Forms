using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class frmLogin : Form
    {
        private int Id;
        public frmLogin()
        {
            InitializeComponent();
        }
        public frmLogin(int id)
        {
            InitializeComponent();
            this.Id = id;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtPassword.Text == "123123")
            {
                this.Hide();
                Form1 f = new Form1();
                f.Show();
            } else
            {
                lblError.Text = "UserName or Password not Valid! Id: " + Id;
                lblError.Visible = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
