using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuy_Winform1
{
    internal class Employee
    {
        private int id;
        private string name;
        private int age;
        private string address;
        private int year_experience;
        private string quanlification;
        private long phone;
        private string email;

        public Employee()
        {
        }

        public Employee(int id, string name, int age, string address, int year_experience, string quanlification, long phone, string email)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.address = address;
            this.year_experience = year_experience;
            this.quanlification = quanlification;
            this.phone = phone;
            this.email = email;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }
        public int Year_experience { get => year_experience; set => year_experience = value; }
        public string Quanlification { get => quanlification; set => quanlification = value; }
        public long Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            return "ID : " +id+ " ; " +
                " Name : " + name+ " ; " +
                " Age : " + age + " ; " +
                " Adress : " + address + "  ;" +
                " Year Experience : " + year_experience + " ; " +
                " Quanlification : " + quanlification + " ; " +
                " Phone : " + phone + " ; " +
                " Email : " + email +
                "";
        }
    }
}
