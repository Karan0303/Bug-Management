using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUG
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            if (MyConnection.type == "a")
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
            }
            else if(MyConnection.type == "D") { 
                button1.Visible=false;
                button2.Visible = false;
                button3.Visible = true;
                button4.Visible = false;
                button5.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectForm projectForm = new ProjectForm();
            projectForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Status st=new Status();
            st.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeForm empForm = new EmployeeForm();  
            empForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Priority_form pri=new Priority_form();
            pri.Show(); 
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BugInfo bugInfo = new BugInfo();
            bugInfo.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           //  LoginForm f1 = new LoginForm();
           // f1.Show();
            this.Close();
        }
    }
}
