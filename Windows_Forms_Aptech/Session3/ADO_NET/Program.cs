using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            CategoryADO categoryADO = new CategoryADO();
            int count = categoryADO.Insert(name);
            Console.WriteLine(count);
            foreach (DataRow row in categoryADO.getAll().Rows)
            {
                Console.WriteLine("Id: {0} - Category Name: {1}", row.Field<int>("Id"),
                    row.Field<string>("CategoryName"));
            }
            Console.ReadLine();
        }
    }
}
