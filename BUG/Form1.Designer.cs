namespace BUG
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Login_lbl = new System.Windows.Forms.Label();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.Login_box = new System.Windows.Forms.TextBox();
            this.Password_box = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Login_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_lbl
            // 
            this.Login_lbl.AutoSize = true;
            this.Login_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Login_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Login_lbl.Location = new System.Drawing.Point(275, 193);
            this.Login_lbl.Name = "Login_lbl";
            this.Login_lbl.Size = new System.Drawing.Size(46, 16);
            this.Login_lbl.TabIndex = 0;
            this.Login_lbl.Text = "Login :";
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Password_lbl.Location = new System.Drawing.Point(275, 237);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(73, 16);
            this.Password_lbl.TabIndex = 1;
            this.Password_lbl.Text = "Password :";
            // 
            // Login_box
            // 
            this.Login_box.Location = new System.Drawing.Point(381, 193);
            this.Login_box.Name = "Login_box";
            this.Login_box.Size = new System.Drawing.Size(100, 20);
            this.Login_box.TabIndex = 2;
            // 
            // Password_box
            // 
            this.Password_box.Location = new System.Drawing.Point(381, 237);
            this.Password_box.Name = "Password_box";
            this.Password_box.Size = new System.Drawing.Size(100, 20);
            this.Password_box.TabIndex = 3;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(204, 25);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(366, 139);
            this.PictureBox1.TabIndex = 4;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Login_btn.ForeColor = System.Drawing.Color.Blue;
            this.Login_btn.Location = new System.Drawing.Point(338, 298);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(103, 38);
            this.Login_btn.TabIndex = 5;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Password_box);
            this.Controls.Add(this.Login_box);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.Login_lbl);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_lbl;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.TextBox Login_box;
        private System.Windows.Forms.TextBox Password_box;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button Login_btn;
    }
}

