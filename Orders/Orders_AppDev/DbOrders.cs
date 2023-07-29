using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders_AppDev
{
    internal class DbOrders
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost; port=3306; username=root; password=; database=app_dev";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        public static void AddOrder(Order order) 
        {
            string sql = "INSERT INTO tborder VALUES (NULL, @customer_name, @product_name, @qty, @total, NULL)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@customer_name", MySqlDbType.VarChar).Value = order.CustomerName;
            cmd.Parameters.Add("@product_name", MySqlDbType.VarChar).Value = order.ProductName;
            cmd.Parameters.Add("@qty", MySqlDbType.VarChar).Value = order.Quantity;
            cmd.Parameters.Add("@total", MySqlDbType.VarChar).Value = order.Total;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Order not added! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void UpdateOrder(Order order, string order_id)
        {
            string sql = "UPDATE tborder SET CustomerName = @customer_name, ProductName = @product_name, Quantity = @qty, Total = @total WHERE order_id = @order_id";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@order_id", MySqlDbType.VarChar).Value = order_id;
            cmd.Parameters.Add("@customer_name", MySqlDbType.VarChar).Value = order.CustomerName;
            cmd.Parameters.Add("@product_name", MySqlDbType.VarChar).Value = order.ProductName;
            cmd.Parameters.Add("@qty", MySqlDbType.VarChar).Value = order.Quantity;
            cmd.Parameters.Add("@total", MySqlDbType.VarChar).Value = order.Total;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Order not updated! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void DeleteOrder(string order_id)
        {
            string sql = "DELETE FROM tborder WHERE order_id = @order_id";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@order_id", MySqlDbType.VarChar).Value = order_id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Order not delete! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void DisplayandSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand( sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            conn.Close(); 
        }


 


    }
}
