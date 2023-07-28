using MySql.Data.MySqlClient;
using Orders_AppDev;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales
{
    internal class DbProducts
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
        public static void DisplayandSearch(string query, DataGridView dgv)
        {
            try
            {
                string sql = query;
                MySqlConnection conn = GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgv.DataSource = tbl;
                conn.Close();

                foreach (DataRow row in tbl.Rows)
                {
                    // Access the values of individual columns (cells) in the row
                    string column1Value = row["SKU"].ToString(); // Replace "Column1" with the actual column name

                    // Do something with the data, for example, print to the console
                    Console.WriteLine($"Column1: {column1Value}");
                }
            }
            catch (Exception ex)
            {
                // Print the exception message to the console or show it in a MessageBox
                //Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DeleteProduct(string SKU)
        {
            string sql = "DELETE FROM tbproducts WHERE SKU = @SKU";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@SKU", MySqlDbType.VarChar).Value = SKU;

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
        public static void addProducts(productGetSet products)
        {
            string sql = "INSERT INTO tbproducts VALUES (0, @product_name, @product_type, @price, @product_quantity, @description)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@product_name", MySqlDbType.VarChar).Value = products.productName;
            cmd.Parameters.Add("@product_type", MySqlDbType.VarChar).Value = products.productType;
            cmd.Parameters.Add("@price", MySqlDbType.Int32).Value = products.price;
            cmd.Parameters.Add("@product_quantity", MySqlDbType.Int32).Value = products.quantity;
            cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = products.description;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                //Console.WriteLine("SQL Error: " + ex.Message);

                MessageBox.Show("Order not added! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void updateProduct(productGetSet products, string SKU)
        {
            string sql = "UPDATE tbproducts SET product_name = @product_name, product_type = @product_type, price = @price, product_quantity = @product_quantity,  description = @description WHERE SKU = @SKU";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@SKU", MySqlDbType.VarChar).Value = SKU;
            cmd.Parameters.Add("@product_name", MySqlDbType.VarChar).Value = products.productName;
            cmd.Parameters.Add("@product_type", MySqlDbType.VarChar).Value = products.productType;
            cmd.Parameters.Add("@price", MySqlDbType.Int32).Value = products.price;
            cmd.Parameters.Add("@product_quantity", MySqlDbType.Int32).Value = products.quantity;
            cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = products.description;

            string completeSqlQuery = BuildCompleteSqlQuery(cmd);
            Console.WriteLine("SQL Query: " + completeSqlQuery);

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
        private static string BuildCompleteSqlQuery(MySqlCommand command)
        {
            string completeQuery = command.CommandText;

            foreach (MySqlParameter parameter in command.Parameters)
            {
                string parameterName = parameter.ParameterName;
                string parameterValue = parameter.Value.ToString();

                // Replace the parameter placeholders with the actual values
                completeQuery = completeQuery.Replace(parameterName, "'" + parameterValue + "'");
            }

            return completeQuery;
        }
    }
}
