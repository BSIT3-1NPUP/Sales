using MySql.Data.MySqlClient;
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

    }
}
