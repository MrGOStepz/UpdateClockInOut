namespace UpdateClockInOut
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFirstName = new System.Windows.Forms.ComboBox();
            this.dtpSearchET = new System.Windows.Forms.DateTimePicker();
            this.dtpSearchST = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUpdateStaff = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpUpdateET = new System.Windows.Forms.DateTimePicker();
            this.dtpUpdateST = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbFirstName);
            this.groupBox1.Controls.Add(this.dtpSearchET);
            this.groupBox1.Controls.Add(this.dtpSearchST);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(7, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(179, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Staff Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Time";
            // 
            // cbFirstName
            // 
            this.cbFirstName.FormattingEnabled = true;
            this.cbFirstName.Location = new System.Drawing.Point(65, 22);
            this.cbFirstName.Name = "cbFirstName";
            this.cbFirstName.Size = new System.Drawing.Size(121, 21);
            this.cbFirstName.TabIndex = 2;
            // 
            // dtpSearchET
            // 
            this.dtpSearchET.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpSearchET.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchET.Location = new System.Drawing.Point(466, 16);
            this.dtpSearchET.Name = "dtpSearchET";
            this.dtpSearchET.Size = new System.Drawing.Size(146, 20);
            this.dtpSearchET.TabIndex = 1;
            // 
            // dtpSearchST
            // 
            this.dtpSearchST.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpSearchST.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchST.Location = new System.Drawing.Point(253, 16);
            this.dtpSearchST.Name = "dtpSearchST";
            this.dtpSearchST.Size = new System.Drawing.Size(146, 20);
            this.dtpSearchST.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStaff);
            this.groupBox2.Location = new System.Drawing.Point(7, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 373);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Time";
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.Location = new System.Drawing.Point(3, 16);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.Size = new System.Drawing.Size(599, 354);
            this.dgvStaff.TabIndex = 0;
            this.dgvStaff.SelectionChanged += new System.EventHandler(this.dgvStaff_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtUpdateStaff);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dtpUpdateET);
            this.groupBox3.Controls.Add(this.dtpUpdateST);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(614, 85);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Staff Name";
            // 
            // txtUpdateStaff
            // 
            this.txtUpdateStaff.Location = new System.Drawing.Point(65, 25);
            this.txtUpdateStaff.Name = "txtUpdateStaff";
            this.txtUpdateStaff.ReadOnly = true;
            this.txtUpdateStaff.Size = new System.Drawing.Size(121, 20);
            this.txtUpdateStaff.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(7, 56);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Staff Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "End Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Start Time";
            // 
            // dtpUpdateET
            // 
            this.dtpUpdateET.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpUpdateET.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUpdateET.Location = new System.Drawing.Point(466, 16);
            this.dtpUpdateET.Name = "dtpUpdateET";
            this.dtpUpdateET.Size = new System.Drawing.Size(146, 20);
            this.dtpUpdateET.TabIndex = 1;
            // 
            // dtpUpdateST
            // 
            this.dtpUpdateST.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpUpdateST.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUpdateST.Location = new System.Drawing.Point(253, 16);
            this.dtpUpdateST.Name = "dtpUpdateST";
            this.dtpUpdateST.Size = new System.Drawing.Size(146, 20);
            this.dtpUpdateST.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Update Time Clock In/Out";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpSearchET;
        private System.Windows.Forms.DateTimePicker dtpSearchST;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFirstName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpUpdateET;
        private System.Windows.Forms.DateTimePicker dtpUpdateST;
        private System.Windows.Forms.TextBox txtUpdateStaff;
    }
}

