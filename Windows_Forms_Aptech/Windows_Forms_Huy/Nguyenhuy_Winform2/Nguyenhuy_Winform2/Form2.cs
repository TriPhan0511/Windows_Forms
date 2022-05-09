using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Nguyenhuy_Winform2
{
    public partial class Form2 : Form
    {
        List<Student> listStudents = new List<Student>() {
              new Student(1, "Nguyen Huy"),
              new Student(2, "Phan Phu Tri"),
              new Student(3, "Nguyen Van A"),
              new Student(4, "Nguyen Van B"),
              new Student(5, "Nguyen Van Duc"),
              new Student(6, "Nguyen Anh Hung"),
              new Student(7, "Dang Minh Hau"),
              new Student(8, "Nguyen Hao Phuc")
        };
        public Form2()
        {
            InitializeComponent();
            LoadListview();
           
        }
        internal void LoadListview()
        {


            for (int i = 0; i < listStudents.Count; i++)
            {

                ListViewItem listitems = new ListViewItem();
                listitems.Text = listStudents[i].StudentRoll.ToString();
                listitems.SubItems.Add(listStudents[i].StudentName);               
                listViewStudentList.Items.Add(listitems);

            }

        }
   

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   string attentdance;
            ListViewItem listViewItem = listViewStudentList.SelectedItems[0];
            listViewItem.SubItems.Add(checkRadioButton());
           
        }
        string checkRadioButton()
        {
            string str = null;
            if (radioButton1.Checked == true) str = "present";
            if (radioButton2.Checked == true) str = "absent";
            return str;
        }

        private void listViewStudentList_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
