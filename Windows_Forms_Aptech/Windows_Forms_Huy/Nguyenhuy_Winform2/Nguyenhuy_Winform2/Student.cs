using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nguyenhuy_Winform2
{
    internal class Student
    { 
        private int _studentRoll;
        private string _studentName;

        public Student()
        {
        }

        public Student(int studentRoll, string studentName)
        {
            StudentRoll = studentRoll;
            StudentName = studentName;
        }

        public int StudentRoll { get => _studentRoll; set => _studentRoll = value; }
        public string StudentName { get => _studentName; set => _studentName = value; }
      
    }
}

