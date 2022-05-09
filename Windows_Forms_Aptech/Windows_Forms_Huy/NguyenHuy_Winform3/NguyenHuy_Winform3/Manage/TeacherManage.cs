using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NguyenHuy_Winform3.ADO;

namespace NguyenHuy_Winform3.Manage
{
    internal class TeacherManage
    {
        private static List<Teacher> teacherList = new List<Teacher>();

        public TeacherManage()
        {
        }

        public static List<Teacher> TeacherList
        {
            get
            {
             
                foreach (DataRow row in DBO.TeacherData.Tables[0].Rows)
                {
                    
                  Teacher teacher=  new Teacher(Convert.ToInt32(row[0]), row[1].ToString(), row[2].ToString(), Convert.ToInt64(row[3]), row[4].ToString()
                     , row[5].ToString(), Convert.ToInt32(row[6]), Convert.ToInt32(row[7]));
                    teacherList.Add(teacher);
                }
                    return teacherList;
            }
            private set
            {
                teacherList = value;
            }
        }
       
    }
}
