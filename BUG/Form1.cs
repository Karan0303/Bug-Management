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
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=10.168.16.78\\MSSQLSRV2019;Initial Catalog=SQLTraining;User ID=AWLDhrishti;Password=AWLDhrishti;Encrypt=False");
        MyConnection db= new MyConnection();

       

        // public static string type;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {

            try
            {
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("[dbo].[sp_login]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@action", "login");
                    cmd.Parameters.AddWithValue("@loginid", Login_box.Text);

                    cmd.Parameters.AddWithValue("@password", Password_box.Text);
                    MyConnection.kp=Login_box.Text;
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        if (rd[6].ToString() == "Admin")
                        {
                            MyConnection.type = "A";
                        }
                        else if (rd[6].ToString() == "Developer")
                        {

                            MyConnection.type = "D";
                        }
                        MDIParent1 d = new MDIParent1();
                        d.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Fill The Correct Info");
                    }
                    con.Close();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                    }
            
            //Priority_form f2 = new Priority_form();
            //EmployeeForm f2= new EmployeeForm();


            //f2.Show();
            


        }
    }
}
