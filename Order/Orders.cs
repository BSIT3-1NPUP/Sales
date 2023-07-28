using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sales;

namespace Orders_AppDev
{
    public partial class Orders : Form
    {
        Create_order create_order;
        public Orders()
        {
            InitializeComponent();
            create_order = new Create_order(this);
        }

        public void Display()
        {
            DbOrders.DisplayandSearch("SELECT order_id, customer_name, product_name, qty, total FROM tborder", Order_dataGridView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            create_order.Clear();
            create_order.ShowDialog();


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DbOrders.DisplayandSearch("SELECT order_id, customer_name, product_name, qty, total FROM tborder WHERE customer_name LIKE'%"+ txtSearch.Text +"%'", Order_dataGridView);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Orders_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void Order_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //edit
                create_order.Clear();
                create_order.order_id = Order_dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                create_order.customer_name = Order_dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                create_order.product_name = Order_dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                create_order.quantity = Order_dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                create_order.total = Order_dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                create_order.UpdateInfo();
                create_order.ShowDialog();
            }

            if(e.ColumnIndex == 1)
            {
                //delete
                if(MessageBox.Show("Are you sure you want to delete this order?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbOrders.DeleteOrder(Order_dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Order_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
            this.Close();
        }
    }
}
