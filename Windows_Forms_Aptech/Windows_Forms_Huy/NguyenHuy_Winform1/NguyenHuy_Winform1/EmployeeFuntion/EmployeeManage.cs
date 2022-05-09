using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuy_Winform1.EmployeeFuntion
{
    internal class EmployeeManage
    {
       public static List<Employee>_employees=new List<Employee>();

        public EmployeeManage()
        {
        }

       

        public void add(Employee employee)
        {
            _employees.Add(employee);
        }
        public void delete(int i)
        {
            for(int j = 0; j < _employees.Count; j++)
            {   if(i == j)
                _employees.Remove(_employees[j]);
            }
        }
    }
}
