using MySql.Data.MySqlClient;
using Orders_AppDev;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales
{
    public partial class Products : Form
    {
        createProduct createProduct;
        public Products()
        {
            InitializeComponent();
            DbProducts.DisplayandSearch("SELECT * FROM tbproducts", products_dataGridView1);
            createProduct = new createProduct(this);
        }

        private void pSalesBtn_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Close();
        }

        private void pHomeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //edit
                createProduct.SKU = products_dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                createProduct.product_name = products_dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                createProduct.product_type = products_dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                createProduct.price = products_dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                createProduct.quantity = products_dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                createProduct.description = products_dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                createProduct.UpdateInfo();
                createProduct.ShowDialog();
            }

            if (e.ColumnIndex == 1)
            {
                //delete
                if (MessageBox.Show("Are you sure you want to delete this order?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbProducts.DeleteProduct(products_dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            createProduct.Clear();
            createProduct.ShowDialog();
            
        }
        public void Display()
        {
            DbProducts.DisplayandSearch("SELECT * FROM tbproducts", products_dataGridView1);
        }

        private void testbtn2_Click(object sender, EventArgs e)
        {
            //products_dataGridView1.Rows.Add("001", "CD", "Merch", "1000", "5", "Plain CD");
        }

        private void pOrdersBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Orders order = new Orders();
            order.Show();
        }
    }
}
