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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(EmployeeManage._employees.Count + 1, textBoxName.Text,
                                            Convert.ToInt32(textBoxAge.Text), textBoxAddress.Text, Convert.ToInt32(textBoxYearExperient.Text),
                                            textBoxQuanlification.Text, Convert.ToInt64(textBoxPhone.Text), textBoxEmail.Text);
            EmployeeManage._employees.Add(employee);
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
