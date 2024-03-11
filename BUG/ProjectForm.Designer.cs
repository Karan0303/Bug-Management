namespace BUG
{
    partial class ProjectForm
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
            this.ProjectName_lbl = new System.Windows.Forms.Label();
            this.ResponsibleUser_lbl = new System.Windows.Forms.Label();
            this.ProjectName_box = new System.Windows.Forms.TextBox();
            this.Responsible_combobox = new System.Windows.Forms.ComboBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectName_lbl
            // 
            this.ProjectName_lbl.AutoSize = true;
            this.ProjectName_lbl.Location = new System.Drawing.Point(214, 49);
            this.ProjectName_lbl.Name = "ProjectName_lbl";
            this.ProjectName_lbl.Size = new System.Drawing.Size(77, 13);
            this.ProjectName_lbl.TabIndex = 0;
            this.ProjectName_lbl.Text = "Project Name :";
            // 
            // ResponsibleUser_lbl
            // 
            this.ResponsibleUser_lbl.AutoSize = true;
            this.ResponsibleUser_lbl.Location = new System.Drawing.Point(214, 82);
            this.ResponsibleUser_lbl.Name = "ResponsibleUser_lbl";
            this.ResponsibleUser_lbl.Size = new System.Drawing.Size(96, 13);
            this.ResponsibleUser_lbl.TabIndex = 1;
            this.ResponsibleUser_lbl.Text = "Responsible User :";
            // 
            // ProjectName_box
            // 
            this.ProjectName_box.Location = new System.Drawing.Point(387, 49);
            this.ProjectName_box.Name = "ProjectName_box";
            this.ProjectName_box.Size = new System.Drawing.Size(121, 20);
            this.ProjectName_box.TabIndex = 2;
            // 
            // Responsible_combobox
            // 
            this.Responsible_combobox.FormattingEnabled = true;
            this.Responsible_combobox.Location = new System.Drawing.Point(387, 82);
            this.Responsible_combobox.Name = "Responsible_combobox";
            this.Responsible_combobox.Size = new System.Drawing.Size(121, 21);
            this.Responsible_combobox.TabIndex = 3;
            this.Responsible_combobox.SelectedIndexChanged += new System.EventHandler(this.Responsible_combobox_SelectedIndexChanged);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(207, 140);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 4;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(363, 140);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_btn.TabIndex = 5;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(515, 140);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 6;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(198, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(392, 183);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(13, 13);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(43, 22);
            this.Back_btn.TabIndex = 8;
            this.Back_btn.Text = "<-";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Responsible_combobox);
            this.Controls.Add(this.ProjectName_box);
            this.Controls.Add(this.ResponsibleUser_lbl);
            this.Controls.Add(this.ProjectName_lbl);
            this.Name = "ProjectForm";
            this.Text = "ProjectForm";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectName_lbl;
        private System.Windows.Forms.Label ResponsibleUser_lbl;
        private System.Windows.Forms.TextBox ProjectName_box;
        private System.Windows.Forms.ComboBox Responsible_combobox;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Back_btn;
    }
}