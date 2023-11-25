namespace frmTatooBooking
{
    partial class frmArtistDashboard
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
            btnUpdateProfile = new System.Windows.Forms.Button();
            btnCreateDateWork = new System.Windows.Forms.Button();
            dgvDateWork = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            textBox1 = new System.Windows.Forms.TextBox();
            btnUpdateDate = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnDeleteDate = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label2 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btnAgree = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            btnBill = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvDateWork).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.Location = new System.Drawing.Point(696, 36);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new System.Drawing.Size(122, 29);
            btnUpdateProfile.TabIndex = 0;
            btnUpdateProfile.Text = "Update Profile";
            btnUpdateProfile.UseVisualStyleBackColor = true;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            // 
            // btnCreateDateWork
            // 
            btnCreateDateWork.Location = new System.Drawing.Point(677, 477);
            btnCreateDateWork.Name = "btnCreateDateWork";
            btnCreateDateWork.Size = new System.Drawing.Size(141, 56);
            btnCreateDateWork.TabIndex = 1;
            btnCreateDateWork.Text = "Create Date Work";
            btnCreateDateWork.UseVisualStyleBackColor = true;
            btnCreateDateWork.Click += btnCreateDateWork_Click;
            // 
            // dgvDateWork
            // 
            dgvDateWork.AllowUserToAddRows = false;
            dgvDateWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDateWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvDateWork.Location = new System.Drawing.Point(23, 476);
            dgvDateWork.Name = "dgvDateWork";
            dgvDateWork.RowHeadersWidth = 51;
            dgvDateWork.RowTemplate.Height = 29;
            dgvDateWork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvDateWork.Size = new System.Drawing.Size(565, 233);
            dgvDateWork.TabIndex = 2;
            dgvDateWork.CellClick += dgvDateWork_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Visible = false;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Artist";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Work Date";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Start Hours";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "End Hours";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(642, 444);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(86, 27);
            textBox1.TabIndex = 3;
            // 
            // btnUpdateDate
            // 
            btnUpdateDate.Location = new System.Drawing.Point(677, 567);
            btnUpdateDate.Name = "btnUpdateDate";
            btnUpdateDate.Size = new System.Drawing.Size(141, 47);
            btnUpdateDate.TabIndex = 4;
            btnUpdateDate.Text = "Update";
            btnUpdateDate.UseVisualStyleBackColor = true;
            btnUpdateDate.Click += btnUpdateDate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(608, 444);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 20);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // btnDeleteDate
            // 
            btnDeleteDate.Location = new System.Drawing.Point(677, 659);
            btnDeleteDate.Name = "btnDeleteDate";
            btnDeleteDate.Size = new System.Drawing.Size(141, 50);
            btnDeleteDate.TabIndex = 6;
            btnDeleteDate.Text = "Delete";
            btnDeleteDate.UseVisualStyleBackColor = true;
            btnDeleteDate.Click += btnDeleteDate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13 });
            dataGridView1.Location = new System.Drawing.Point(23, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(565, 355);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column6
            // 
            Column6.HeaderText = "ID";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 50;
            // 
            // Column7
            // 
            Column7.HeaderText = "Customer";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Artist";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Date Create";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "Phone Customer";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // Column11
            // 
            Column11.HeaderText = "Date Book";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 125;
            // 
            // Column12
            // 
            Column12.HeaderText = "Time Book";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.Width = 125;
            // 
            // Column13
            // 
            Column13.HeaderText = "Status";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.Width = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(256, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(24, 20);
            label2.TabIndex = 8;
            label2.Text = "ID";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(323, 9);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(79, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(323, 42);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(79, 27);
            textBox3.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(256, 45);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 20);
            label3.TabIndex = 11;
            label3.Text = "Status";
            // 
            // btnAgree
            // 
            btnAgree.Location = new System.Drawing.Point(707, 145);
            btnAgree.Name = "btnAgree";
            btnAgree.Size = new System.Drawing.Size(111, 48);
            btnAgree.TabIndex = 12;
            btnAgree.Text = "Agree";
            btnAgree.UseVisualStyleBackColor = true;
            btnAgree.Click += btnAgree_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new System.Drawing.Point(23, 31);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(122, 29);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBill
            // 
            btnBill.Location = new System.Drawing.Point(707, 338);
            btnBill.Name = "btnBill";
            btnBill.Size = new System.Drawing.Size(94, 29);
            btnBill.TabIndex = 14;
            btnBill.Text = "Bill";
            btnBill.UseVisualStyleBackColor = true;
            btnBill.Click += btnBill_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(608, 299);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(277, 20);
            label4.TabIndex = 15;
            label4.Text = "Enter information after complete tatttoo";
            // 
            // frmArtistDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(899, 730);
            Controls.Add(label4);
            Controls.Add(btnBill);
            Controls.Add(btnLogout);
            Controls.Add(btnAgree);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnDeleteDate);
            Controls.Add(label1);
            Controls.Add(btnUpdateDate);
            Controls.Add(textBox1);
            Controls.Add(dgvDateWork);
            Controls.Add(btnCreateDateWork);
            Controls.Add(btnUpdateProfile);
            Name = "frmArtistDashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmArtistDashboard";
            Load += frmArtistDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDateWork).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnCreateDateWork;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView dgvDateWork;
        private System.Windows.Forms.Button btnUpdateDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgree;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Label label4;
    }
}