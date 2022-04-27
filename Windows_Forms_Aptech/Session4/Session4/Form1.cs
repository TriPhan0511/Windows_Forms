using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demo_DAODataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.demo_DAODataSet.Products);
            // TODO: This line of code loads data into the 'demo_DAODataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.demo_DAODataSet.Categories);
            LoadProducts();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string namesearch = txtSearch.Text;
            if (String.IsNullOrEmpty(namesearch) || namesearch == "")
            {
                categoriesBindingSource.RemoveFilter();
            } else
            {
                categoriesBindingSource.Filter = "CategoryName='" + namesearch + "'";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            categoriesBindingSource.Sort = "CategoryName";
        }
        private void LoadProducts()
        {
            
            var products = from p in demo_DAODataSet.Tables[1].AsEnumerable()
                           join c in demo_DAODataSet.Tables[0].AsEnumerable()
                           on p.Field<int>("CategoryId") equals c.Field<int>("Id")
                           select new { ProductId = p.Field<int>("Id"), 
                           ProductName = p.Field<string>("ProductName"),
                           Amount = p.Field<int>("Amount"), 
                           CategoryName = c.Field<string>("CategoryName"), 
                           CategoryId = p.Field<int>("CategoryId")};
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = products;
            dataGridView3.DataSource = bindingSource;
            dataGridView3.Columns[4].Visible = false;
        }
    }
}
