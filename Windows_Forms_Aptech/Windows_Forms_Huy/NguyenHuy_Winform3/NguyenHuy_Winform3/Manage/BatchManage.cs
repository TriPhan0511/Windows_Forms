using NguyenHuy_Winform3.ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuy_Winform3.Manage
{
    internal class BatchManage
    {
        private static List<Batch> batchList = new List<Batch>();

        public BatchManage()
        {
        }

        public static List<Batch> BatchList
        {
            get
            {
             
                foreach (DataRow row in DBO.BatchData.Tables[0].Rows)
                {
                 Batch batch=  new Batch(Convert.ToInt32(row[0]), row[1].ToString(), row[2].ToString());
                 batchList.Add(batch);
                }
                return batchList;
            }
            set { batchList = value; }
        }
    }
}
