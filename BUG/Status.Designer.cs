namespace BUG
{
    partial class Status
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Check_box = new System.Windows.Forms.CheckBox();
            this.Status_box = new System.Windows.Forms.TextBox();
            this.Active_lbl = new System.Windows.Forms.Label();
            this.Priority_lbl = new System.Windows.Forms.Label();
            this.Back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(113, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(450, 230);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.Color.LightCoral;
            this.Cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Cancel_btn.Location = new System.Drawing.Point(210, 134);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 13;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.LightGreen;
            this.Save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Save_btn.Location = new System.Drawing.Point(124, 134);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 12;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Check_box
            // 
            this.Check_box.AutoSize = true;
            this.Check_box.Location = new System.Drawing.Point(210, 93);
            this.Check_box.Name = "Check_box";
            this.Check_box.Size = new System.Drawing.Size(15, 14);
            this.Check_box.TabIndex = 11;
            this.Check_box.UseVisualStyleBackColor = true;
            // 
            // Status_box
            // 
            this.Status_box.Location = new System.Drawing.Point(210, 53);
            this.Status_box.Name = "Status_box";
            this.Status_box.Size = new System.Drawing.Size(100, 20);
            this.Status_box.TabIndex = 10;
            // 
            // Active_lbl
            // 
            this.Active_lbl.AutoSize = true;
            this.Active_lbl.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Active_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Active_lbl.Location = new System.Drawing.Point(126, 93);
            this.Active_lbl.Name = "Active_lbl";
            this.Active_lbl.Size = new System.Drawing.Size(50, 16);
            this.Active_lbl.TabIndex = 9;
            this.Active_lbl.Text = "Active :";
            // 
            // Priority_lbl
            // 
            this.Priority_lbl.AutoSize = true;
            this.Priority_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Priority_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Priority_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Priority_lbl.Location = new System.Drawing.Point(124, 53);
            this.Priority_lbl.Name = "Priority_lbl";
            this.Priority_lbl.Size = new System.Drawing.Size(52, 18);
            this.Priority_lbl.TabIndex = 8;
            this.Priority_lbl.Text = "Status :";
            this.Priority_lbl.Click += new System.EventHandler(this.Priority_lbl_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(13, 13);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(31, 23);
            this.Back_btn.TabIndex = 15;
            this.Back_btn.Text = "<-";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Check_box);
            this.Controls.Add(this.Status_box);
            this.Controls.Add(this.Active_lbl);
            this.Controls.Add(this.Priority_lbl);
            this.Name = "Status";
            this.Text = "Status";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.CheckBox Check_box;
        private System.Windows.Forms.TextBox Status_box;
        private System.Windows.Forms.Label Active_lbl;
        private System.Windows.Forms.Label Priority_lbl;
        private System.Windows.Forms.Button Back_btn;
    }
}