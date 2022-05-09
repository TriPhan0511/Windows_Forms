using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuy_Winform3.Manage
{
    internal class Teacher
    {   
        private int id_teacher;
        private string teacher_name;
        private string birthday;
        private long phone;
        private string gender;
        private string email;
        private int id_user;
        private int  id_batch;

        public Teacher(int id_teacher, string teacher_name, string birthday, long phone, string gender, string email, int id_user, int id_batch)
        {
            this.Id_teacher = id_teacher;
            this.Teacher_name = teacher_name;
            this.Birthday = birthday;
            this.Phone = phone;
            this.Gender = gender;
            this.Email = email;
            this.Id_user = id_user;
            this.Id_batch = id_batch;
        }

        public int Id_teacher { get => id_teacher; set => id_teacher = value; }
        public string Teacher_name { get => teacher_name; set => teacher_name = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public long Phone { get => phone; set => phone = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public int Id_user { get => id_user; set => id_user = value; }
        public int Id_batch { get => id_batch; set => id_batch = value; }
    }
}
