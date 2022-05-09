using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NguyenHuy_Winform3.ADO;

namespace NguyenHuy_Winform3.StudentManage
{
    internal class User
    {
        private int id_user;
        private string us_name;
        private string pass_word;
        private string user_role;

        public User(int id_user, string us_name, string pass_word, string user_role)
        {
            this.id_user = id_user;
            this.us_name = us_name;
            this.pass_word = pass_word;
            this.user_role = user_role;
        }

        public int Id_user { get => id_user; set => id_user = value; }
        public string Us_name { get => us_name; set => us_name = value; }
        public string Pass_word { get => pass_word; set => pass_word = value; }
        public string User_role { get => user_role; set => user_role = value; }
      
    }
}
