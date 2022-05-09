using NguyenHuy_Winform3.ADO;
using NguyenHuy_Winform3.StudentManage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuy_Winform3.Manage
{
    internal class UserManage
    {
        private static List<User> userList=new List<User>();

        public UserManage()
        {
        }

        public static List<User> UserList { get {
                foreach(DataRow datarow in DBO.UserData.Tables[0].Rows)
                { User user = new User(Convert.ToInt32(datarow[0]), datarow[1].ToString(), datarow[2].ToString(), datarow[3].ToString());
                    userList.Add(user);
                };
                return userList; } set { userList = value; } }
    }
}
