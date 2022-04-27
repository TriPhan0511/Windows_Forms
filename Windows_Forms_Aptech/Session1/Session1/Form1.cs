using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadList()
        {
            ArrayList myList = new ArrayList()
            {
                "Nguyen Van A",
                "Nguyen Van B"
            };
            ltbDemo.DataSource = myList;

            //foreach (string item in myList)
            //{
            //    ltbDemo.Items.Add(item);
            //                //}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin f = new frmLogin(1);
            f.Show();
            
        }

        private void ltbDemo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ltbDemo.SelectedIndex.ToString());
        }

        
    }
}
