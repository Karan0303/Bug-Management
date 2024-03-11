namespace BUG
{
    partial class Priority_form
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
            this.Priority_lbl = new System.Windows.Forms.Label();
            this.Active_lbl = new System.Windows.Forms.Label();
            this.Priority_box = new System.Windows.Forms.TextBox();
            this.Check_box = new System.Windows.Forms.CheckBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Priority_lbl
            // 
            this.Priority_lbl.AutoSize = true;
            this.Priority_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Priority_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Priority_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Priority_lbl.Location = new System.Drawing.Point(180, 57);
            this.Priority_lbl.Name = "Priority_lbl";
            this.Priority_lbl.Size = new System.Drawing.Size(56, 18);
            this.Priority_lbl.TabIndex = 1;
            this.Priority_lbl.Text = "Priority :";
            // 
            // Active_lbl
            // 
            this.Active_lbl.AutoSize = true;
            this.Active_lbl.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Active_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Active_lbl.Location = new System.Drawing.Point(182, 97);
            this.Active_lbl.Name = "Active_lbl";
            this.Active_lbl.Size = new System.Drawing.Size(50, 16);
            this.Active_lbl.TabIndex = 2;
            this.Active_lbl.Text = "Active :";
            // 
            // Priority_box
            // 
            this.Priority_box.Location = new System.Drawing.Point(266, 57);
            this.Priority_box.Name = "Priority_box";
            this.Priority_box.Size = new System.Drawing.Size(100, 20);
            this.Priority_box.TabIndex = 3;
            // 
            // Check_box
            // 
            this.Check_box.AutoSize = true;
            this.Check_box.Location = new System.Drawing.Point(266, 97);
            this.Check_box.Name = "Check_box";
            this.Check_box.Size = new System.Drawing.Size(15, 14);
            this.Check_box.TabIndex = 4;
            this.Check_box.UseVisualStyleBackColor = true;
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.LightGreen;
            this.Save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Save_btn.Location = new System.Drawing.Point(180, 138);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 5;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.Color.LightCoral;
            this.Cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Cancel_btn.Location = new System.Drawing.Point(266, 138);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 6;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(144, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(450, 230);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(34, 70);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(53, 21);
            this.Back_btn.TabIndex = 9;
            this.Back_btn.Text = "<-";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Priority_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Check_box);
            this.Controls.Add(this.Priority_box);
            this.Controls.Add(this.Active_lbl);
            this.Controls.Add(this.Priority_lbl);
            this.Name = "Priority_form";
            this.Text = "Priority_form";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Priority_lbl;
        private System.Windows.Forms.Label Active_lbl;
        private System.Windows.Forms.TextBox Priority_box;
        private System.Windows.Forms.CheckBox Check_box;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Back_btn;
    }
}