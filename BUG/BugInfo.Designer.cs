namespace BUG
{
    partial class BugInfo
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
            this.BugName_lbl = new System.Windows.Forms.Label();
            this.BugDescription_lbl = new System.Windows.Forms.Label();
            this.Project_lbl = new System.Windows.Forms.Label();
            this.Priority_lbl = new System.Windows.Forms.Label();
            this.AssignedBy_lbl = new System.Windows.Forms.Label();
            this.AssignedTo_lbl = new System.Windows.Forms.Label();
            this.DateAssigned_lbl = new System.Windows.Forms.Label();
            this.Status_lbl = new System.Windows.Forms.Label();
            this.DateResolved_lbl = new System.Windows.Forms.Label();
            this.Resolution_lbl = new System.Windows.Forms.Label();
            this.Project_combobox = new System.Windows.Forms.ComboBox();
            this.Priority_combobox = new System.Windows.Forms.ComboBox();
            this.AssignedTo_combobox = new System.Windows.Forms.ComboBox();
            this.BugName_box = new System.Windows.Forms.TextBox();
            this.BugDescription_box = new System.Windows.Forms.TextBox();
            this.Resolution_box = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Back_btn = new System.Windows.Forms.Button();
            this.AssignedBy_box = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.Status_combobox = new System.Windows.Forms.ComboBox();
            this.Delete_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BugName_lbl
            // 
            this.BugName_lbl.AutoSize = true;
            this.BugName_lbl.Location = new System.Drawing.Point(12, 9);
            this.BugName_lbl.Name = "BugName_lbl";
            this.BugName_lbl.Size = new System.Drawing.Size(63, 13);
            this.BugName_lbl.TabIndex = 0;
            this.BugName_lbl.Text = "Bug Name :";
            // 
            // BugDescription_lbl
            // 
            this.BugDescription_lbl.AutoSize = true;
            this.BugDescription_lbl.Location = new System.Drawing.Point(12, 48);
            this.BugDescription_lbl.Name = "BugDescription_lbl";
            this.BugDescription_lbl.Size = new System.Drawing.Size(88, 13);
            this.BugDescription_lbl.TabIndex = 1;
            this.BugDescription_lbl.Text = "Bug Description :";
            // 
            // Project_lbl
            // 
            this.Project_lbl.AutoSize = true;
            this.Project_lbl.Location = new System.Drawing.Point(12, 87);
            this.Project_lbl.Name = "Project_lbl";
            this.Project_lbl.Size = new System.Drawing.Size(46, 13);
            this.Project_lbl.TabIndex = 2;
            this.Project_lbl.Text = "Project :";
            // 
            // Priority_lbl
            // 
            this.Priority_lbl.AutoSize = true;
            this.Priority_lbl.Location = new System.Drawing.Point(12, 126);
            this.Priority_lbl.Name = "Priority_lbl";
            this.Priority_lbl.Size = new System.Drawing.Size(44, 13);
            this.Priority_lbl.TabIndex = 3;
            this.Priority_lbl.Text = "Priority :";
            // 
            // AssignedBy_lbl
            // 
            this.AssignedBy_lbl.AutoSize = true;
            this.AssignedBy_lbl.Location = new System.Drawing.Point(12, 165);
            this.AssignedBy_lbl.Name = "AssignedBy_lbl";
            this.AssignedBy_lbl.Size = new System.Drawing.Size(71, 13);
            this.AssignedBy_lbl.TabIndex = 4;
            this.AssignedBy_lbl.Text = "Assigned By :";
            // 
            // AssignedTo_lbl
            // 
            this.AssignedTo_lbl.AutoSize = true;
            this.AssignedTo_lbl.Location = new System.Drawing.Point(12, 204);
            this.AssignedTo_lbl.Name = "AssignedTo_lbl";
            this.AssignedTo_lbl.Size = new System.Drawing.Size(72, 13);
            this.AssignedTo_lbl.TabIndex = 5;
            this.AssignedTo_lbl.Text = "Assigned To :";
            // 
            // DateAssigned_lbl
            // 
            this.DateAssigned_lbl.AutoSize = true;
            this.DateAssigned_lbl.Location = new System.Drawing.Point(12, 243);
            this.DateAssigned_lbl.Name = "DateAssigned_lbl";
            this.DateAssigned_lbl.Size = new System.Drawing.Size(82, 13);
            this.DateAssigned_lbl.TabIndex = 6;
            this.DateAssigned_lbl.Text = "Date Assigned :";
            // 
            // Status_lbl
            // 
            this.Status_lbl.AutoSize = true;
            this.Status_lbl.Location = new System.Drawing.Point(12, 282);
            this.Status_lbl.Name = "Status_lbl";
            this.Status_lbl.Size = new System.Drawing.Size(43, 13);
            this.Status_lbl.TabIndex = 7;
            this.Status_lbl.Text = "Status :";
            // 
            // DateResolved_lbl
            // 
            this.DateResolved_lbl.AutoSize = true;
            this.DateResolved_lbl.Location = new System.Drawing.Point(12, 321);
            this.DateResolved_lbl.Name = "DateResolved_lbl";
            this.DateResolved_lbl.Size = new System.Drawing.Size(84, 13);
            this.DateResolved_lbl.TabIndex = 8;
            this.DateResolved_lbl.Text = "Date Resolved :";
            // 
            // Resolution_lbl
            // 
            this.Resolution_lbl.AutoSize = true;
            this.Resolution_lbl.Location = new System.Drawing.Point(12, 360);
            this.Resolution_lbl.Name = "Resolution_lbl";
            this.Resolution_lbl.Size = new System.Drawing.Size(63, 13);
            this.Resolution_lbl.TabIndex = 9;
            this.Resolution_lbl.Text = "Resolution :";
            // 
            // Project_combobox
            // 
            this.Project_combobox.FormattingEnabled = true;
            this.Project_combobox.Location = new System.Drawing.Point(122, 88);
            this.Project_combobox.Name = "Project_combobox";
            this.Project_combobox.Size = new System.Drawing.Size(100, 21);
            this.Project_combobox.TabIndex = 10;
            this.Project_combobox.SelectedIndexChanged += new System.EventHandler(this.Project_combobox_SelectedIndexChanged);
            // 
            // Priority_combobox
            // 
            this.Priority_combobox.FormattingEnabled = true;
            this.Priority_combobox.Location = new System.Drawing.Point(122, 130);
            this.Priority_combobox.Name = "Priority_combobox";
            this.Priority_combobox.Size = new System.Drawing.Size(100, 21);
            this.Priority_combobox.TabIndex = 11;
            // 
            // AssignedTo_combobox
            // 
            this.AssignedTo_combobox.FormattingEnabled = true;
            this.AssignedTo_combobox.Location = new System.Drawing.Point(122, 204);
            this.AssignedTo_combobox.Name = "AssignedTo_combobox";
            this.AssignedTo_combobox.Size = new System.Drawing.Size(100, 21);
            this.AssignedTo_combobox.TabIndex = 12;
            // 
            // BugName_box
            // 
            this.BugName_box.Location = new System.Drawing.Point(122, 6);
            this.BugName_box.Name = "BugName_box";
            this.BugName_box.Size = new System.Drawing.Size(100, 20);
            this.BugName_box.TabIndex = 13;
            // 
            // BugDescription_box
            // 
            this.BugDescription_box.Location = new System.Drawing.Point(122, 47);
            this.BugDescription_box.Name = "BugDescription_box";
            this.BugDescription_box.Size = new System.Drawing.Size(100, 20);
            this.BugDescription_box.TabIndex = 14;
            // 
            // Resolution_box
            // 
            this.Resolution_box.Location = new System.Drawing.Point(122, 360);
            this.Resolution_box.Name = "Resolution_box";
            this.Resolution_box.Size = new System.Drawing.Size(100, 20);
            this.Resolution_box.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(264, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(524, 429);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(15, 414);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(43, 24);
            this.Back_btn.TabIndex = 21;
            this.Back_btn.Text = "<-";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // AssignedBy_box
            // 
            this.AssignedBy_box.Location = new System.Drawing.Point(122, 165);
            this.AssignedBy_box.Name = "AssignedBy_box";
            this.AssignedBy_box.Size = new System.Drawing.Size(100, 20);
            this.AssignedBy_box.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 243);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(122, 321);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 24);
            this.button1.TabIndex = 24;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Status_combobox
            // 
            this.Status_combobox.FormattingEnabled = true;
            this.Status_combobox.Location = new System.Drawing.Point(122, 282);
            this.Status_combobox.Name = "Status_combobox";
            this.Status_combobox.Size = new System.Drawing.Size(121, 21);
            this.Status_combobox.TabIndex = 25;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(157, 415);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_btn.TabIndex = 26;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // BugInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Status_combobox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Resolution_box);
            this.Controls.Add(this.AssignedBy_box);
            this.Controls.Add(this.BugDescription_box);
            this.Controls.Add(this.BugName_box);
            this.Controls.Add(this.AssignedTo_combobox);
            this.Controls.Add(this.Priority_combobox);
            this.Controls.Add(this.Project_combobox);
            this.Controls.Add(this.Resolution_lbl);
            this.Controls.Add(this.DateResolved_lbl);
            this.Controls.Add(this.Status_lbl);
            this.Controls.Add(this.DateAssigned_lbl);
            this.Controls.Add(this.AssignedTo_lbl);
            this.Controls.Add(this.AssignedBy_lbl);
            this.Controls.Add(this.Priority_lbl);
            this.Controls.Add(this.Project_lbl);
            this.Controls.Add(this.BugDescription_lbl);
            this.Controls.Add(this.BugName_lbl);
            this.Name = "BugInfo";
            this.Text = "BugInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BugName_lbl;
        private System.Windows.Forms.Label BugDescription_lbl;
        private System.Windows.Forms.Label Project_lbl;
        private System.Windows.Forms.Label Priority_lbl;
        private System.Windows.Forms.Label AssignedBy_lbl;
        private System.Windows.Forms.Label AssignedTo_lbl;
        private System.Windows.Forms.Label DateAssigned_lbl;
        private System.Windows.Forms.Label Status_lbl;
        private System.Windows.Forms.Label DateResolved_lbl;
        private System.Windows.Forms.Label Resolution_lbl;
        private System.Windows.Forms.ComboBox Project_combobox;
        private System.Windows.Forms.ComboBox Priority_combobox;
        private System.Windows.Forms.ComboBox AssignedTo_combobox;
        private System.Windows.Forms.TextBox BugName_box;
        private System.Windows.Forms.TextBox BugDescription_box;
        private System.Windows.Forms.TextBox Resolution_box;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.TextBox AssignedBy_box;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Status_combobox;
        private System.Windows.Forms.Button Delete_btn;
    }
}