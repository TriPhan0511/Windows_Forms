using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NguyenHuy_Winform1.EmployeeFuntion;

namespace NguyenHuy_Winform1
{
    public partial class Form1 : Form
    {
        List <Employee> employees=EmployeeManage._employees;
        BindingSource bindingSource= new BindingSource() ;

        
        public Form1()
        {
           
            InitializeComponent();  
            load_Listview();

        }
        void load_Listview()
        {
            if (employees != null)
            {
                bindingSource.DataSource =employees;
                lbxEmployee.DataSource = bindingSource;
                bindingSource.ResetBindings(false);
            }
        }
 

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = lbxEmployee.SelectedIndex;
            new EmployeeManage().delete(id);
            lbxEmployee.DataSource = bindingSource;
            bindingSource.ResetBindings(false);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
