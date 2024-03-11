namespace BUG
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_lbl = new System.Windows.Forms.Label();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.SecurityLevel_lbl = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.DOB_lbl = new System.Windows.Forms.Label();
            this.Login_box = new System.Windows.Forms.TextBox();
            this.Password_box = new System.Windows.Forms.TextBox();
            this.Email_box = new System.Windows.Forms.TextBox();
            this.SecutityLevel_combobox = new System.Windows.Forms.ComboBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name_box = new System.Windows.Forms.TextBox();
            this.Back_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_lbl
            // 
            this.Login_lbl.AutoSize = true;
            this.Login_lbl.Location = new System.Drawing.Point(78, 26);
            this.Login_lbl.Name = "Login_lbl";
            this.Login_lbl.Size = new System.Drawing.Size(39, 13);
            this.Login_lbl.TabIndex = 0;
            this.Login_lbl.Text = "Login :";
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Location = new System.Drawing.Point(78, 77);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(59, 13);
            this.Password_lbl.TabIndex = 1;
            this.Password_lbl.Text = "Password :";
            // 
            // SecurityLevel_lbl
            // 
            this.SecurityLevel_lbl.AutoSize = true;
            this.SecurityLevel_lbl.Location = new System.Drawing.Point(78, 113);
            this.SecurityLevel_lbl.Name = "SecurityLevel_lbl";
            this.SecurityLevel_lbl.Size = new System.Drawing.Size(80, 13);
            this.SecurityLevel_lbl.TabIndex = 2;
            this.SecurityLevel_lbl.Text = "Security Level :";
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Location = new System.Drawing.Point(83, 147);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(41, 13);
            this.Name_lbl.TabIndex = 3;
            this.Name_lbl.Text = "Name :";
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Location = new System.Drawing.Point(83, 178);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(38, 13);
            this.Email_lbl.TabIndex = 4;
            this.Email_lbl.Text = "Email :";
            // 
            // DOB_lbl
            // 
            this.DOB_lbl.AutoSize = true;
            this.DOB_lbl.Location = new System.Drawing.Point(83, 213);
            this.DOB_lbl.Name = "DOB_lbl";
            this.DOB_lbl.Size = new System.Drawing.Size(36, 13);
            this.DOB_lbl.TabIndex = 5;
            this.DOB_lbl.Text = "DOB :";
            // 
            // Login_box
            // 
            this.Login_box.Location = new System.Drawing.Point(198, 26);
            this.Login_box.Name = "Login_box";
            this.Login_box.Size = new System.Drawing.Size(100, 20);
            this.Login_box.TabIndex = 6;
            // 
            // Password_box
            // 
            this.Password_box.Location = new System.Drawing.Point(198, 70);
            this.Password_box.Name = "Password_box";
            this.Password_box.Size = new System.Drawing.Size(100, 20);
            this.Password_box.TabIndex = 7;
            // 
            // Email_box
            // 
            this.Email_box.Location = new System.Drawing.Point(198, 175);
            this.Email_box.Name = "Email_box";
            this.Email_box.Size = new System.Drawing.Size(100, 20);
            this.Email_box.TabIndex = 8;
            // 
            // SecutityLevel_combobox
            // 
            this.SecutityLevel_combobox.FormattingEnabled = true;
            this.SecutityLevel_combobox.Items.AddRange(new object[] {
            "Administrator",
            "Developer"});
            this.SecutityLevel_combobox.Location = new System.Drawing.Point(198, 105);
            this.SecutityLevel_combobox.Name = "SecutityLevel_combobox";
            this.SecutityLevel_combobox.Size = new System.Drawing.Size(121, 21);
            this.SecutityLevel_combobox.TabIndex = 10;
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(44, 259);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 11;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(140, 259);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_btn.TabIndex = 12;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(248, 259);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 13;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(375, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(413, 337);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // Name_box
            // 
            this.Name_box.Location = new System.Drawing.Point(198, 140);
            this.Name_box.Name = "Name_box";
            this.Name_box.Size = new System.Drawing.Size(100, 20);
            this.Name_box.TabIndex = 15;
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(13, 13);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(26, 26);
            this.Back_btn.TabIndex = 16;
            this.Back_btn.Text = "<-";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 207);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Name_box);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.SecutityLevel_combobox);
            this.Controls.Add(this.Email_box);
            this.Controls.Add(this.Password_box);
            this.Controls.Add(this.Login_box);
            this.Controls.Add(this.DOB_lbl);
            this.Controls.Add(this.Email_lbl);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.SecurityLevel_lbl);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.Login_lbl);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_lbl;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.Label SecurityLevel_lbl;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label Email_lbl;
        private System.Windows.Forms.Label DOB_lbl;
        private System.Windows.Forms.TextBox Login_box;
        private System.Windows.Forms.TextBox Password_box;
        private System.Windows.Forms.TextBox Email_box;
        private System.Windows.Forms.ComboBox SecutityLevel_combobox;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Name_box;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}