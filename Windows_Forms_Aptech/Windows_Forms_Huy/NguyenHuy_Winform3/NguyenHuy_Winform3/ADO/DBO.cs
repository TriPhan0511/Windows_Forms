using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuy_Winform3.ADO
{
    internal class DBO
    {
        private static DataSet batchData;
        private static DataSet studentData;
        private static DataSet teacherData;
        private static DataSet userData;
        private static DataSet attendanceData;

        public static DataSet BatchData
        {
            get
            {
                batchData = new DAO().ExcuteQuery("select *  from _batches");
                return batchData;
            }
            private set { batchData = value; }
        }
        public static DataSet StudentData
        {
            get
            {
                studentData = new DAO().ExcuteQuery("select * from students");
                return studentData;
            }
            private set
            {
                studentData = value;
            }
        }

        public static DataSet TeacherData
        {
            get
            {
                teacherData = new DAO().ExcuteQuery("select * from teachers");
                return teacherData;
            }
            set { teacherData = value; }
        }
        public static DataSet UserData
        {
            get
            {
                userData = new DAO().ExcuteQuery("select * from users");
                return userData;
            }
            set { userData = value; }
        }
        public static DataSet AttendentData
        {
            get
            {
                attendanceData = new DAO().ExcuteQuery("select * from attendance");
                return attendanceData;
            }
            set { attendanceData = value; }
        }

    }
}



