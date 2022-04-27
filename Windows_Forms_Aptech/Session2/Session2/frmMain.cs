using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // new frmDemo("Ban muon tiep tuc hay khong!").ShowDialog();
            label1.Text = "HIC HIC";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban co muon tiep tuc", "Thong bao", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                label1.Text = "HEHE";
            } 
            else
            {
                label1.Text = "HUHU";
            }
            //{

                //}
                // this.button2.Click += new EventHandler(button3_Click);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "HIHI";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            label1.Text = "Hello moi nguoi";
            this.button2.Click += new EventHandler(button3_Click);
            this.button2.Click += new EventHandler(button1_Click);
            this.button2.Click += new EventHandler(frmMain_Load);
            // this.button2.Click += new EventHandler(button2_Click);
        }
    }
}
