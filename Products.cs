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
        public Products()
        {
            InitializeComponent();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("001", "CD", "Merch", "1000", "5", "Plain CD");
        }
    }
}
