using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUG
{
    public partial class Status : Form
    {
        SqlConnection con = new SqlConnection("Data Source=10.168.16.78\\MSSQLSRV2019;Initial Catalog=SQLTraining;User ID=AWLDhrishti;Password=AWLDhrishti;Encrypt=False");
        MyConnection db = new MyConnection();
        int intGlCode = 0;

        public Status()
        {
            InitializeComponent();
            Display();
           
        }
        public void Display()
        {
            SqlCommand cmd = new SqlCommand("[dbo].[sp_status]", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@action", "Show");
            System.Data.DataTable dt = new System.Data.DataTable();
           // cmd.Parameters.AddWithValue("@action", "Show");
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void Priority_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            DashBoard da=new DashBoard();
            da.Show();
            this.Close();

        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            /*
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("[dbo].[sp_status]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    cmd.Parameters.AddWithValue("@action", "Insert");
                    cmd.Parameters.AddWithValue("@txtStatus", Status_box.Text);
                    cmd.Parameters.AddWithValue("@cbActive", Check_box.Checked ? "true" : "false");
                    cmd.ExecuteNonQuery();
                    Display();
                    con.Close();
                }
            */
            try
            {
                con.Open();
                if (intGlCode != 0)
                {
                    SqlCommand cmd = new SqlCommand("[dbo].[sp_status]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@action", "Update");
                    cmd.Parameters.AddWithValue("@txtStatus", Status_box.Text);
                    cmd.Parameters.AddWithValue("@intGlCode", intGlCode);
                    cmd.Parameters.AddWithValue("@cbActive", Check_box.Checked ? "true" : "false");
                    cmd.ExecuteNonQuery();
                    Display();
                }
                else
                {
                    if (Status_box.Text == "")
                    {
                        MessageBox.Show("Please intsert value...");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("[dbo].[sp_status]", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@action", "Insert");
                        cmd.Parameters.AddWithValue("@txtStatus", Status_box.Text);
                        cmd.Parameters.AddWithValue("@cbActive", Check_box.Checked ? "true" : "false");
                        cmd.ExecuteNonQuery();
                        Display();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                con.Close();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            intGlCode = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Status_box.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() == "Y")
            {
                Check_box.Checked = true; // Set checkbox as checked
            }
            else
            {
                Check_box.Checked = false; // Set checkbox as unchecked
            }
        }
    }
}
