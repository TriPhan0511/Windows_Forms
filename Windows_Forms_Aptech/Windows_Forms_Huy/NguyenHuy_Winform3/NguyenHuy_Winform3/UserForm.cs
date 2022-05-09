using NguyenHuy_Winform3.ADO;
using NguyenHuy_Winform3.Manage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenHuy_Winform3
{
    public partial class UserForm : Form
    {   
        BindingSource bindingSource=new BindingSource();
        public UserForm()
        {
            InitializeComponent();
            load_DatagridviewUser();


        }
        void load_DatagridviewUser()
        {
            bindingSource.DataSource = UserManage.UserList;
           dataGridViewUser.DataSource = bindingSource;
            dataGridViewUser.Columns[0].Visible = false;
            dataGridViewUser.Columns[2].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to add new user?", "ADD new user", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)
            {
              int i=  new DAO().ExcuteNonQuery("insert into users(us_name ,pass_word ,user_role)values('" +
                   textBoxUserName.Text +
                    "', '" +
                    "defauld" +
                    "', '" +
                    textBoxUserRole.Text +
                    "')");
                if (i > 0) { labellabelNotification.Text = "Add " + i + " student into database Success!!"; }
            }    
        }
    }
}
