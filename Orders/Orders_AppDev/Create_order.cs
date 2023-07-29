using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders_AppDev
{
    public partial class Create_order : Form
    {
        private readonly Orders _parent;
        public string order_id, customer_name, product_name, quantity, total;

        public Create_order(Orders parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void Clear()
        {
            txtCustomer_Name.Text = txtProduct.Text = txtQuantity.Text = txtTotal.Text = string.Empty;
        }

        public void UpdateInfo()
        {
            label6.Text ="Update Order";
            btnSave.Text = "Update";
            txtCustomer_Name.Text = customer_name;
            txtProduct.Text = product_name;
            txtQuantity.Text = quantity;
            txtTotal.Text = total;

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Create_order_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }


        private void Create_btn_Click(object sender, EventArgs e)
        {
            if (txtCustomer_Name.Text.Trim().Length < 3)
            {
                MessageBox.Show("Customer Name is Empty");
                return;
            }

            if (txtProduct.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please select a product");
                return;
            }

            if (txtQuantity.Text.Trim().Length == 0)
            {
                MessageBox.Show("Quantity is Empty");
                return;
            }

            if(btnSave.Text == "Save")
            {
                Order order = new Order(txtCustomer_Name.Text.Trim(), txtProduct.Text.Trim(), txtQuantity.Text.Trim(), txtTotal.Text.Trim());
                DbOrders.AddOrder(order);
                Clear();
            }

            if(btnSave.Text == "Update")
            {
                Order order = new Order(txtCustomer_Name.Text.Trim(), txtProduct.Text.Trim(), txtQuantity.Text.Trim(), txtTotal.Text.Trim());
                DbOrders.UpdateOrder(order, order_id);
            }
            _parent.Display();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
