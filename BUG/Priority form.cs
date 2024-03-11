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
    public partial class Priority_form : Form
    {
        SqlConnection con = new SqlConnection("Data Source=10.168.16.78\\MSSQLSRV2019;Initial Catalog=SQLTraining;User ID=AWLDhrishti;Password=AWLDhrishti;Encrypt=False");
        MyConnection db = new MyConnection();
        int intGlCode = 0;
        public Priority_form()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=10.168.16.78\\MSSQLSRV2019;Initial Catalog=SQLTraining;User ID=AWLDhrishti;Password=AWLDhrishti;Encrypt=False");
            Display();
        }

        public void Display()
        {
            
            SqlCommand showq = new SqlCommand("Select * from [dbo].[Priority_mst]", con);
            SqlDataAdapter data = new SqlDataAdapter(showq);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            
            /*
            SqlCommand cmd = new SqlCommand("[dbo].[sp_status]", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@action", "Show");
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            */
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
           //// DashBoard da = new DashBoard();
           // da.Show();
            //this.Close();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            MDIParent1 m1 = new MDIParent1();
            m1.Close();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (intGlCode != 0)
                {
                    SqlCommand cmd = new SqlCommand("[dbo].[sp_priority]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@action", "Update");
                    cmd.Parameters.AddWithValue("@txtPriority", Priority_box.Text);
                    cmd.Parameters.AddWithValue("@intGlCode", intGlCode);
                    cmd.Parameters.AddWithValue("@cbActive", Check_box.Checked ? "true" : "false");
                    cmd.ExecuteNonQuery();
                    Display();
                }
                else
                {
                    if (Priority_box.Text == "")
                    {
                        MessageBox.Show("Please intsert value...");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("[dbo].[sp_priority]", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@action", "Insert");
                        cmd.Parameters.AddWithValue("@txtPriority", Priority_box.Text);
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
            Priority_box.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() == "Y"|| dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() == "Yes" || dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() == "y")
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
