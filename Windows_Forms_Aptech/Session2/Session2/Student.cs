using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    class Student
    {
        public Student(int id, string name, int age)
        {
            this.Id = id;
            StudentName = name;
            Age = age;
        }
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        
    }
}
