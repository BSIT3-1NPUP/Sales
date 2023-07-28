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
    public partial class createProduct : Form
    {
        private readonly Products _parent;
        public string SKU, product_name, product_type, price, quantity, description;
        public createProduct(Products parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void UpdateInfo()
        {
            //label6.Text = "Update Order";
            addBtn.Text = "Update";
            name_txtbox.Text = product_name;
            type_txtbox.Text = product_type;
            price_txtbox.Text = price;
            quantity_txtbox.Text = quantity;
            description_txtbox.Text = description;

            Console.WriteLine(SKU);
            Console.WriteLine(product_name);
            Console.WriteLine(product_type);
            Console.WriteLine(price);
            Console.WriteLine(quantity);
            Console.WriteLine(description);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void name_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
