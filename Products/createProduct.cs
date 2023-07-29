using Orders_AppDev;
using static Sales.Products;
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

        private void button1_Click(object sender, EventArgs e) //ADD BUTTON
        {
            if (addBtn.Text == "ADD")
            {
                int price;
                int quantity;

                // Attempt to parse the input values to integers
                if (int.TryParse(price_txtbox.Text, out price) && int.TryParse(quantity_txtbox.Text, out quantity))
                {
                    // Both price and quantity were successfully parsed as integers
                    productGetSet product = new productGetSet(name_txtbox.Text, type_txtbox.Text, price, quantity, description_txtbox.Text);
                    DbProducts.addProducts(product);
                    Clear();
                }
                else
                {
                    // Parsing failed for price_txtbox.Text or quantity_txtbox.Text
                    // Show an error message or handle the case appropriately
                    MessageBox.Show("Invalid price or quantity input. Please enter valid integer values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (addBtn.Text == "Update")
            {
                int price;
                int quantity;

                // Attempt to parse the input values to integers
                if (int.TryParse(price_txtbox.Text, out price) && int.TryParse(quantity_txtbox.Text, out quantity))
                {
                    // Both price and quantity were successfully parsed as integers
                    productGetSet product = new productGetSet(name_txtbox.Text, type_txtbox.Text, price, quantity, description_txtbox.Text);
                    DbProducts.updateProduct(product, SKU);
                    Clear();
                    this.Close();
                }
                else
                {
                    // Parsing failed for price_txtbox.Text or quantity_txtbox.Text
                    // Show an error message or handle the case appropriately
                    MessageBox.Show("Invalid price or quantity input. Please enter valid integer values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            _parent.Display();
        }

        private void name_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            name_txtbox.Text = type_txtbox.Text = price_txtbox.Text = quantity_txtbox.Text = description_txtbox.Text = string.Empty;
        }
    }
}
