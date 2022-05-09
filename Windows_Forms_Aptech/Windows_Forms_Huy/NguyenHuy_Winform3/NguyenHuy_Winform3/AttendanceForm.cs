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

namespace NguyenHuy_Winform3
{
    public partial class AttendanceForm : Form
    {
        BindingSource data = new BindingSource();
        public AttendanceForm()
        {
            InitializeComponent();
            Load_DatagridView();
        }
        void Load_DatagridView()
        {
            var Student=from p in DBO.StudentData.Tables[0].AsEnumerable()
                        join c  in DBO.BatchData.Tables[0].AsEnumerable()
                        on p.Field<int>("id_batch") equals c.Field<int>("id_batch")
                        where c.Field<string>("batch_name")=="batch164"                                       
                        select new { Student_Name=p.Field<string>("student_name") }
                        ;
            data.DataSource = Student;
            dataGridViewAttendance.DataSource = data;
            
        }


    }
}
