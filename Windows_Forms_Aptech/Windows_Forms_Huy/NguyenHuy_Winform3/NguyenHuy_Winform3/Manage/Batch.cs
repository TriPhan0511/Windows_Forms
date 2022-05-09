using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuy_Winform3.Manage
{
    internal class Batch
    {
        private int id_batch;
        private string batch_name;
        private string description;

        public Batch(int id_batch, string batch_name, string description)
        {
            this.Id_batch = id_batch;
            this.Batch_name = batch_name;
            this.Description = description;
        }

        public int Id_batch { get => id_batch; set => id_batch = value; }
        public string Batch_name { get => batch_name; set => batch_name = value; }
        public string Description { get => description; set => description = value; }
    }
}
