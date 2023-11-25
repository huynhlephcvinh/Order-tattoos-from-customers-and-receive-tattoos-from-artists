namespace frmTatooBooking
{
    partial class frmArtistManagememt
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
            dgvArtistList = new System.Windows.Forms.DataGridView();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ArtistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            StudioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            StudioName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Degree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            txtPhone = new System.Windows.Forms.TextBox();
            txtDegree = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            cbbStudio = new System.Windows.Forms.ComboBox();
            btnView = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvArtistList).BeginInit();
            SuspendLayout();
            // 
            // dgvArtistList
            // 
            dgvArtistList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArtistList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, ArtistName, Email, Password, StudioID, StudioName, Degree, Phone, Address });
            dgvArtistList.Location = new System.Drawing.Point(14, 445);
            dgvArtistList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvArtistList.Name = "dgvArtistList";
            dgvArtistList.RowHeadersWidth = 51;
            dgvArtistList.RowTemplate.Height = 25;
            dgvArtistList.Size = new System.Drawing.Size(1205, 333);
            dgvArtistList.TabIndex = 0;
            dgvArtistList.CellClick += dgvArtistList_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 70;
            // 
            // ArtistName
            // 
            ArtistName.HeaderText = "Artist Name";
            ArtistName.MinimumWidth = 6;
            ArtistName.Name = "ArtistName";
            ArtistName.Width = 130;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 130;
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
            StudioName.Width = 130;
            // 
            // Degree
            // 
            Degree.HeaderText = "Degree";
            Degree.MinimumWidth = 6;
            Degree.Name = "Degree";
            Degree.Width = 125;
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.Width = 125;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(198, 69);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(198, 113);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(49, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(198, 155);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(198, 199);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new System.Drawing.Point(290, 65);
            txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(231, 27);
            txtID.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(290, 109);
            txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(231, 27);
            txtName.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(290, 195);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(231, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(290, 151);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(231, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(790, 195);
            txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(231, 27);
            txtAddress.TabIndex = 16;
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(790, 151);
            txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(231, 27);
            txtPhone.TabIndex = 15;
            // 
            // txtDegree
            // 
            txtDegree.Location = new System.Drawing.Point(790, 109);
            txtDegree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDegree.Name = "txtDegree";
            txtDegree.Size = new System.Drawing.Size(231, 27);
            txtDegree.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(697, 199);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 20);
            label4.TabIndex = 12;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(697, 155);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 20);
            label5.TabIndex = 11;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(697, 113);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(58, 20);
            label6.TabIndex = 10;
            label6.Text = "Degree";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(697, 69);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(52, 20);
            label7.TabIndex = 9;
            label7.Text = "Studio";
            // 
            // cbbStudio
            // 
            cbbStudio.Enabled = false;
            cbbStudio.FormattingEnabled = true;
            cbbStudio.Location = new System.Drawing.Point(790, 65);
            cbbStudio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbbStudio.Name = "cbbStudio";
            cbbStudio.Size = new System.Drawing.Size(231, 28);
            cbbStudio.TabIndex = 17;
            // 
            // btnView
            // 
            btnView.Location = new System.Drawing.Point(341, 283);
            btnView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(86, 31);
            btnView.TabIndex = 18;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(703, 283);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(86, 31);
            btnSave.TabIndex = 50;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(576, 283);
            btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(86, 31);
            btnUpdate.TabIndex = 48;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(459, 283);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(86, 31);
            btnDelete.TabIndex = 47;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(337, 349);
            txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Insert name to find artist";
            txtSearch.Size = new System.Drawing.Size(582, 27);
            txtSearch.TabIndex = 51;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(829, 283);
            btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(86, 31);
            btnExit.TabIndex = 52;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmArtistManagememt
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1231, 795);
            Controls.Add(btnExit);
            Controls.Add(txtSearch);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnView);
            Controls.Add(cbbStudio);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtDegree);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblName);
            Controls.Add(label1);
            Controls.Add(dgvArtistList);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmArtistManagememt";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmArtistManagememt";
            ((System.ComponentModel.ISupportInitialize)dgvArtistList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtistList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudioName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Degree;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDegree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbStudio;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnExit;
    }
}