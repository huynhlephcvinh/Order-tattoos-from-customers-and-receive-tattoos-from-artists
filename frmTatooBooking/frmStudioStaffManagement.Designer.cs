namespace frmTatooBooking
{
    partial class frmStudioStaffManagement
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
            btnExit = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnView = new System.Windows.Forms.Button();
            cbbStudio = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            dgvStudioStaffList = new System.Windows.Forms.DataGridView();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            StudioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            StudioName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label4 = new System.Windows.Forms.Label();
            cbbStatus = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudioStaffList).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(828, 268);
            btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(86, 31);
            btnExit.TabIndex = 75;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(219, 307);
            txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Insert name to find staff";
            txtSearch.Size = new System.Drawing.Size(778, 27);
            txtSearch.TabIndex = 74;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(704, 268);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(86, 31);
            btnSave.TabIndex = 73;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(581, 268);
            btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(86, 31);
            btnUpdate.TabIndex = 72;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(447, 268);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(86, 31);
            btnDelete.TabIndex = 71;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnView
            // 
            btnView.Location = new System.Drawing.Point(312, 268);
            btnView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(86, 31);
            btnView.TabIndex = 70;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // cbbStudio
            // 
            cbbStudio.Enabled = false;
            cbbStudio.FormattingEnabled = true;
            cbbStudio.Location = new System.Drawing.Point(766, 85);
            cbbStudio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbbStudio.Name = "cbbStudio";
            cbbStudio.Size = new System.Drawing.Size(231, 28);
            cbbStudio.TabIndex = 69;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(673, 89);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(52, 20);
            label7.TabIndex = 62;
            label7.Text = "Studio";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(766, 41);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(231, 27);
            txtPassword.TabIndex = 61;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(312, 127);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(231, 27);
            txtEmail.TabIndex = 60;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(312, 85);
            txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(231, 27);
            txtName.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(673, 45);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 20);
            label3.TabIndex = 57;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(219, 131);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 20);
            label2.TabIndex = 56;
            label2.Text = "Email";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(219, 89);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(49, 20);
            lblName.TabIndex = 55;
            lblName.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(219, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 20);
            label1.TabIndex = 54;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new System.Drawing.Point(312, 41);
            txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(231, 27);
            txtID.TabIndex = 58;
            // 
            // dgvStudioStaffList
            // 
            dgvStudioStaffList.AllowUserToAddRows = false;
            dgvStudioStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudioStaffList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, StaffName, Email, Password, StudioID, StudioName, Status });
            dgvStudioStaffList.Location = new System.Drawing.Point(14, 367);
            dgvStudioStaffList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvStudioStaffList.Name = "dgvStudioStaffList";
            dgvStudioStaffList.RowHeadersWidth = 51;
            dgvStudioStaffList.RowTemplate.Height = 25;
            dgvStudioStaffList.Size = new System.Drawing.Size(1050, 333);
            dgvStudioStaffList.TabIndex = 53;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 70;
            // 
            // StaffName
            // 
            StaffName.HeaderText = "Staff Name";
            StaffName.MinimumWidth = 6;
            StaffName.Name = "StaffName";
            StaffName.Width = 200;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 200;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.Width = 130;
            // 
            // StudioID
            // 
            StudioID.HeaderText = "Studio ID";
            StudioID.MinimumWidth = 6;
            StudioID.Name = "StudioID";
            StudioID.Width = 70;
            // 
            // StudioName
            // 
            StudioName.HeaderText = "Studio Name";
            StudioName.MinimumWidth = 6;
            StudioName.Name = "StudioName";
            StudioName.Width = 200;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(673, 133);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 20);
            label4.TabIndex = 76;
            label4.Text = "Status";
            // 
            // cbbStatus
            // 
            cbbStatus.Enabled = false;
            cbbStatus.FormattingEnabled = true;
            cbbStatus.Items.AddRange(new object[] { "True", "False" });
            cbbStatus.Location = new System.Drawing.Point(766, 127);
            cbbStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbbStatus.Name = "cbbStatus";
            cbbStatus.Size = new System.Drawing.Size(231, 28);
            cbbStatus.TabIndex = 77;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.Info;
            button1.Location = new System.Drawing.Point(691, 199);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(99, 31);
            button1.TabIndex = 78;
            button1.Text = "Statistical";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Firebrick;
            label5.Location = new System.Drawing.Point(376, 204);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(291, 20);
            label5.TabIndex = 79;
            label5.Text = "Customer bill after tattooing is completed:";
            // 
            // frmStudioStaffManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1081, 795);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(cbbStatus);
            Controls.Add(label4);
            Controls.Add(btnExit);
            Controls.Add(txtSearch);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnView);
            Controls.Add(cbbStudio);
            Controls.Add(label7);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblName);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(dgvStudioStaffList);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmStudioStaffManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Staff Management For Admin";
            ((System.ComponentModel.ISupportInitialize)dgvStudioStaffList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ComboBox cbbStudio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvStudioStaffList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudioName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}