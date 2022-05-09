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
    public partial class DaskBoardForm : Form
    {
        public DaskBoardForm(string str1,string str2)
        {
            InitializeComponent();
            ToolStripItemCollection toolStripItemColection = menuStrip1.Items;
            foreach (ToolStripItem item in toolStripItemColection)
            {
                if(item.Text ==str1)
                {
                    item.Visible = false;
                }
            }
            labelBatchName.Text = str2;



        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {   
           
            StudentManageForm form=new StudentManageForm();
            form.ShowDialog();  
         
           
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttendanceForm attendanceForm = new AttendanceForm();
            attendanceForm.ShowDialog();
        }
    }
}
