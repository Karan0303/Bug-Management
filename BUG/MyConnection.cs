using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUG
{
    internal class MyConnection
    {
        //public SqlConnection con;
        /*public MyConnection()
        {
            try
            {
                string connectionString = ConfigurationManager.AppSettings["cc"];

                if (string.IsNullOrEmpty(connectionString))
                {
                    // Handle the case where the connection string is null or empty
                    MessageBox.Show("Connection string 'cc' is null or empty.");
                }
                else
                {
                    // Create a new SqlConnection using the retrieved connection string
                    con = new SqlConnection(connectionString);
                }
            }
            catch (Exception ex)
            {
                // Handle any exception that might occur during the connection initialization
                MessageBox.Show($"Error initializing connection: {ex.Message}");
            }
        }
        */
        public static string type;
        public static string kp;
        public static int num;
    }
}
