using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BUG
{
    public partial class BugInfo : Form
    {
        SqlConnection con = new SqlConnection("Data Source=10.168.16.78\\MSSQLSRV2019;Initial Catalog=SQLTraining;User ID=AWLDhrishti;Password=AWLDhrishti;Encrypt=False");
        MyConnection db = new MyConnection();
        int intGlCode = 0;
        public BugInfo()
        {
            InitializeComponent();
            Display();
            SqlConnection con = new SqlConnection("Data Source=10.168.16.78\\MSSQLSRV2019;Initial Catalog=SQLTraining;User ID=AWLDhrishti;Password=AWLDhrishti;Encrypt=False");
            PopulateComboBoxes();
        }
        public void Display()
        {

            try
            {
                SqlCommand cmd = new SqlCommand("sp_Bug", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                System.Data.DataTable dt = new System.Data.DataTable();
                cmd.Parameters.AddWithValue("@action", "Show");
               
               
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
        private void Back_btn_Click(object sender, EventArgs e)
        {
            DashBoard da = new DashBoard();
            da.Show();
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=10.168.16.78\\MSSQLSRV2019;Initial Catalog=SQLTraining;User ID=AWLDhrishti;Password=AWLDhrishti;Encrypt=False"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("[dbo].[sp_Bug]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                   // cmd.Parameters.AddWithValue("@intGlCode", intGlCode);
                    cmd.Parameters.AddWithValue("@varBugName", BugName_box.Text);
                    cmd.Parameters.AddWithValue("@varBugDesc", BugDescription_box.Text);
                    cmd.Parameters.AddWithValue("@fk_ProjectGlCode", Project_combobox.Text);
                    cmd.Parameters.AddWithValue("@fk_PriorityGlCode", Priority_combobox.Text);
                    //cmd.Parameters.AddWithValue("@fk_EmpGlCodeAssignedTo", AssignedBy_box.Text);
                    cmd.Parameters.AddWithValue("@fk_EmpGlCodeAssignedTo", AssignedTo_combobox.Text);
                    cmd.Parameters.AddWithValue("@dtDateAssigned", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@fk_StatusGlCode", Status_combobox.Text);
                    cmd.Parameters.AddWithValue("@dtDateResolved", dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@varBugResolution", Resolution_box.Text);
                    cmd.Parameters.AddWithValue("@action", "Insert");
                  //  int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Sr No"].Value);
                    if (intGlCode != 0)
                    {
                        cmd = new SqlCommand("[dbo].[sp_Bug]", con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters for update
                        cmd.Parameters.AddWithValue("@varBugName", BugName_box.Text);
                        cmd.Parameters.AddWithValue("@intGlCode", intGlCode);
                        
                        cmd.Parameters.AddWithValue("@varBugDesc", BugDescription_box.Text);
                        cmd.Parameters.AddWithValue("@fk_ProjectGlCode", Project_combobox.Text);
                        cmd.Parameters.AddWithValue("@fk_PriorityGlCode", Priority_combobox.Text);
                        //cmd.Parameters.AddWithValue("@fk_EmpGlCodeAssignedTo", AssignedBy_box.Text);
                        cmd.Parameters.AddWithValue("@fk_EmpGlCodeAssignedTo", AssignedTo_combobox.Text);
                        cmd.Parameters.AddWithValue("@dtDateAssigned", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@fk_StatusGlCode", Status_combobox.Text);
                        cmd.Parameters.AddWithValue("@dtDateResolved", dateTimePicker2.Value);
                        cmd.Parameters.AddWithValue("@varBugResolution", Resolution_box.Text);
                        
                        cmd.Parameters.AddWithValue("@action", "Update1");
                        
                        cmd.ExecuteNonQuery();
                        Display();

                        MessageBox.Show("Record Updated Successfully");
                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                        Display();
                        MessageBox.Show("Record inserted successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void PopulateComboBoxes()
        {
            try
            {
                using (con)
                {
                    con.Open();

                    // Populate Responsible ComboBox
                    using (SqlCommand cmd = new SqlCommand("SELECT varProjectName FROM Project_mst", con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Project_combobox.Items.Add(reader["varProjectName"].ToString());
                            }
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT varPriority FROM Priority_mst", con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Priority_combobox.Items.Add(reader["varPriority"].ToString());
                            }
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT varEmpName FROM Employee_mst", con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AssignedTo_combobox.Items.Add(reader["varEmpName"].ToString());
                            }
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT varStatus FROM Status_mst", con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Status_combobox.Items.Add(reader["varStatus"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while populating combo box: " + ex.Message);
            }
        }

        private void Project_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=10.168.16.78\\MSSQLSRV2019;Initial Catalog=SQLTraining;User ID=AWLDhrishti;Password=AWLDhrishti;Encrypt=False"))

            {
                con.Open();
               // int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Sr No"].Value);

                 intGlCode = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                BugName_box.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Priority_combobox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Project_combobox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                Status_combobox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                AssignedTo_combobox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();



                SqlCommand cmd = new SqlCommand("sp_Bug", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@intGlCode", intGlCode);
                cmd.Parameters.AddWithValue("@action", "see");

                SqlDataReader myReader = cmd.ExecuteReader();

                if (myReader.Read())
                {
                    BugDescription_box.Text = (myReader["varBugDesc"].ToString());
                    Resolution_box.Text = (myReader["varBugResolution"].ToString());
                }

                con.Close();
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

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection con = new SqlConnection("Data Source=10.168.16.78\\MSSQLSRV2019;Initial Catalog=SQLTraining;User ID=AWLDhrishti;Password=AWLDhrishti;Encrypt=False"))
                {
                    if (intGlCode != 0)
                    {
                        SqlCommand cmd = new SqlCommand("sp_Bug", con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@intGlCode", intGlCode);
                        cmd.Parameters.AddWithValue("@action", "Delete");

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        Display();
                        MessageBox.Show("Record Deleted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Please Select Record to Delete");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
    }
}
