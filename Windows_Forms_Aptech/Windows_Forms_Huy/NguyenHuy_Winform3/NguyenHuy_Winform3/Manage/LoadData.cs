using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenHuy_Winform3.Manage
{
    internal class LoadData
    {
        public static void LoadDataGridView(DataGridView dataGridView, BindingSource bindingSource)
        {   
            dataGridView.DataSource = bindingSource;
        }
    }
}
