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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;
        SqlConnection con = new SqlConnection("Data Source=10.168.16.78\\MSSQLSRV2019;Initial Catalog=SQLTraining;User ID=AWLDhrishti;Password=AWLDhrishti;Encrypt=False");
        MyConnection db = new MyConnection();

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ProjectForm Pf = new ProjectForm();

            //Pf.Size = new Size(700, 700);
            Pf.TopLevel = false;
            Pf.AutoScroll = true;
            panel1.Controls.Add(Pf);
            Pf.FormBorderStyle = FormBorderStyle.None;
            Pf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Status Pf = new Status();

            //Pf.Size = new Size(800, 700);
            Pf.TopLevel = false;
            Pf.AutoScroll = true;
            panel1.Controls.Add(Pf);
            Pf.FormBorderStyle = FormBorderStyle.None;
            Pf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            EmployeeForm Pf = new EmployeeForm();

            //Pf.Size = new Size(700, 700);
            Pf.TopLevel = false;
            Pf.AutoScroll = true;
            panel1.Controls.Add(Pf);
            Pf.FormBorderStyle = FormBorderStyle.None;
            Pf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Priority_form Pf = new Priority_form();

            //Pf.Size = new Size(700, 700);
            Pf.TopLevel = false;
            Pf.AutoScroll = true;
            panel1.Controls.Add(Pf);
            Pf.FormBorderStyle = FormBorderStyle.None;
            Pf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            BugInfo Pf = new BugInfo();

            //Pf.Size = new Size(700, 700);
            Pf.TopLevel = false;
            Pf.AutoScroll = true;
            panel1.Controls.Add(Pf);
            Pf.FormBorderStyle = FormBorderStyle.None;
            Pf.Show();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

            if (MyConnection.type == "A")
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
            }
            else if (MyConnection.type == "D")
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        { 
            
            


            SqlCommand cmd = new SqlCommand("[dbo].[sp_login]", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@loginid", MyConnection.kp);
            cmd.Parameters.AddWithValue("@action", "logout");

            cmd.ExecuteNonQuery();
            LoginForm LF = new LoginForm();
            LF.Show();
            con.Close();
            this.Close();
        }
    }
}
