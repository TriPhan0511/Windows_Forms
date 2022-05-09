using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuy_Winform3.StudentManage
{
    internal class Student
    {   
        private string _name;
        private string _birthday;
        private long _phone;
        private string _gender;
        private string _email;
        private int _idBatch;

        public Student(string name, string birthday, long phone, string gender, string email, int idBatch)
        {
            _name = name;
            _birthday = birthday;
            _phone = phone;
            _gender = gender;
            _email = email;
            _idBatch = idBatch;
        }

        public string Name { get => _name; set => _name = value; }
        public string Birthday { get => _birthday; set => _birthday = value; }
        public long Phone { get => _phone; set => _phone = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public string Email { get => _email; set => _email = value; }
        public int IdBatch { get => _idBatch; set => _idBatch = value; }
    }
    internal class Batches
    {   
        private int _idBatch;
        private string _batchName;

        public Batches()
        {
        }

        public Batches(int idBatch, string batchName)
        {
            _idBatch = idBatch;
            _batchName = batchName;
        }

        public int IdBatch { get => _idBatch; set => _idBatch = value; }
        public string BatchName { get => _batchName; set => _batchName = value; }
    }
   
}
