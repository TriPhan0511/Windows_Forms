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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //ListViewItem listViewItem = new ListViewItem();
            //listViewItem.Text = "1";
            //listViewItem.SubItems.Add("khantn");
            //listViewItem.SubItems.Add("12");
            //listViewItem.SubItems.Add("123213");
            //listView1.Items.Add(listViewItem);
            //listView1.Show();
            List<Student> students = new List<Student>()
            {
                new Student(1, "khantn", 28),
                new Student(2, "HoangVL", 30)

            };
            ListViewItem listViewItem = new ListViewItem();
            listView1.Show();
        }
    }
}
