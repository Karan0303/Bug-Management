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
using System.Xml.Linq;

namespace BUG
{
    public partial class EmployeeForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=10.168.16.78\\MSSQLSRV2019;Initial Catalog=SQLTraining;User ID=AWLDhrishti;Password=AWLDhrishti;Encrypt=False");
        MyConnection db = new MyConnection();
        int intGlCode = 0;
        public EmployeeForm()
        {
            InitializeComponent();
            Display();
        }
        public void Display()
        {
            SqlCommand cmd = new SqlCommand("[dbo].[Employee_Procedure]", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@action", "Grid"); 
            //cmd.Parameters.AddWithValue("@kp", MyConnection.kp);
            //cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.ExecuteNonQuery();
            // MessageBox.Show(MyConnection.kp);
           
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Login_box.Clear();
            Password_box.Clear();
            SecutityLevel_combobox.SelectedItem = null;
            Name_box.Clear();
            Email_box.Clear() ;
            dateTimePicker1 = null;

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            DashBoard da = new DashBoard();
            da.Show();
            this.Close();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=10.168.16.78\\MSSQLSRV2019;Initial Catalog=SQLTraining;User ID=AWLDhrishti;Password=AWLDhrishti;Encrypt=False"))
                {
                    con.Open();

                    if (intGlCode != 0)
                    {
                        // Update operation
                        using (SqlCommand cmd = new SqlCommand("[dbo].[Employee_Procedure]", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@action", "Update");
                            cmd.Parameters.AddWithValue("@intGlCode", intGlCode);
                            cmd.Parameters.AddWithValue("@varEmpName", Name_box.Text);
                            cmd.Parameters.AddWithValue("@varLoginId", Login_box.Text);
                            cmd.Parameters.AddWithValue("@varPassword", Password_box.Text);
                            cmd.Parameters.AddWithValue("@varEmail", Email_box.Text);
                            cmd.Parameters.AddWithValue("@dtDOB", dateTimePicker1.Value);
                            cmd.Parameters.AddWithValue("@varSecutityLevel", SecutityLevel_combobox.Text); // Corrected the parameter name
                            cmd.ExecuteNonQuery();
                        }

                        // Display the updated data
                        Display();
                    }
                    else
                    {
                        // Insert operation
                        if (string.IsNullOrWhiteSpace(Email_box.Text) && string.IsNullOrWhiteSpace(Login_box.Text) && string.IsNullOrWhiteSpace(Name_box.Text) && string.IsNullOrWhiteSpace(Password_box.Text))
                        {
                            MessageBox.Show("Please insert values...");
                        }
                        else
                        {
                            using (SqlCommand cmd = new SqlCommand("[dbo].[Employee_Procedure]", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@action", "Insert");
                                cmd.Parameters.AddWithValue("@varEmpName", Name_box.Text);
                                cmd.Parameters.AddWithValue("@varLoginId", Login_box.Text);
                                cmd.Parameters.AddWithValue("@varPassword", Password_box.Text);
                                cmd.Parameters.AddWithValue("@varEmail", Email_box.Text);
                                cmd.Parameters.AddWithValue("@dtDOB", dateTimePicker1.Value);
                                cmd.Parameters.AddWithValue("@varSecutityLevel", SecutityLevel_combobox.Text); // Corrected the parameter name
                                cmd.ExecuteNonQuery();
                            }

                            // Display the inserted data
                            Display();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            /*
            SqlCommand cmd = new SqlCommand("[dbo].[Employee_Procedure]", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@action", "Insert");
            cmd.Parameters.AddWithValue("@varLoginId", Login_box.Text);
            cmd.Parameters.AddWithValue("@varPassword", Password_box.Text);
            cmd.Parameters.AddWithValue("@varSecutityLevel", SecutityLevel_combobox.Text);
            cmd.Parameters.AddWithValue("@varEmpName", Name_box.Text);
            cmd.Parameters.AddWithValue("@varEmail", Email_box.Text);
            cmd.Parameters.AddWithValue("@dtDOB", dateTimePicker1.Value);

            cmd.ExecuteNonQuery();
            Display();
            con.Close();
            */
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (intGlCode != 0)
                {
                    SqlCommand cmd = new SqlCommand("Employee_Procedure", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@action", "Delete");
                    cmd.Parameters.AddWithValue("@intGlCode", intGlCode);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted successfull...");
                    Display();
                }
                else
                {
                    MessageBox.Show("Please select row...");
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
            try
            {
                intGlCode = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                Name_box.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Login_box.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Password_box.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                Email_box.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                SecutityLevel_combobox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.TabStop = false;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
