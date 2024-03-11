using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUG
{
    public partial class ProjectForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=10.168.16.78\\MSSQLSRV2019;Initial Catalog=SQLTraining;User ID=AWLDhrishti;Password=AWLDhrishti;Encrypt=False");
        MyConnection db = new MyConnection();
        int intGlCode = 0;

        public ProjectForm()
        {
            InitializeComponent();
            Display();
            PopulateComboBoxes();
            con = new SqlConnection("Data Source=10.168.16.78\\MSSQLSRV2019;Initial Catalog=SQLTraining;User ID=AWLDhrishti;Password=AWLDhrishti;Encrypt=False");
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            //DashBoard da = new DashBoard();
           // da.Show();
            //this.Close();
        }
        public void Display()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Project_Procedure", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                System.Data.DataTable dt = new System.Data.DataTable();

                cmd.Parameters.AddWithValue("@action", "Grid");

                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void Clear()
        {
            ProjectName_box.Text = "";
            //chkActive.Checked = false;
            intGlCode = 0;
        }

        private void PopulateComboBoxes()
        {
            try
            {
                using (con)
                {
                    con.Open();

                    // Populate Responsible ComboBox
                    using (SqlCommand cmd = new SqlCommand("SELECT varempname FROM Employee_mst", con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Responsible_combobox.Items.Add(reader["varempname"].ToString());
                            }
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while populating combo box: " + ex.Message);
            }
            finally { con.Close(); }
        }



       
            private void Save_btn_Click(object sender, EventArgs e)
            {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source = 10.168.16.78\\MSSQLSRV2019; Initial Catalog = SQLTraining; User ID = AWLDhrishti; Password=AWLDhrishti;Encrypt=False"))
                {
                    con.Open();

                    if (intGlCode != 0)
                    {
                        using (SqlCommand cmd = new SqlCommand("[dbo].[Project_Procedure]", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@action", "Update");
                            cmd.Parameters.AddWithValue("@abc", Responsible_combobox.Text);
                            cmd.Parameters.AddWithValue("@intGlCode", intGlCode);
                            cmd.Parameters.AddWithValue("@varProjectName", ProjectName_box.Text);
                            cmd.ExecuteNonQuery();
                        }

                        Display();
                    }
                    else
                    {
                        if (ProjectName_box.Text == "")
                        {
                            MessageBox.Show("Please insert a value...");
                        }
                        else
                        {
                            using (SqlCommand cmd = new SqlCommand("[dbo].[Project_Procedure]", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@action", "Insert");
                                cmd.Parameters.AddWithValue("@abc", Responsible_combobox.Text);
                                cmd.Parameters.AddWithValue("@varProjectName", ProjectName_box.Text);
                                cmd.ExecuteNonQuery();
                            }

                            Display();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }







        private void Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (intGlCode != 0)
                {
                    SqlCommand cmd = new SqlCommand("[dbo].[Project_Procedure]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@action", "Delete");
                    cmd.Parameters.AddWithValue("@intGlCode", intGlCode);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted successfull...");
                    //Display();
                }
                else
                {
                    MessageBox.Show(" abcd ");
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

    private void Responsible_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.TabStop = false;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                intGlCode = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                ProjectName_box.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Responsible_combobox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {

        }
    }
}
