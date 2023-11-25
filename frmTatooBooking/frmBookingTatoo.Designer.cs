namespace frmTatooBooking
{
    partial class frmBookingTatoo
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnLogout = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            btnHistory = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            textBox2 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            labID = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.Location = new System.Drawing.Point(834, 26);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new System.Drawing.Size(128, 37);
            btnUpdateProfile.TabIndex = 0;
            btnUpdateProfile.Text = "Update Profile";
            btnUpdateProfile.UseVisualStyleBackColor = true;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLogout);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnHistory);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnUpdateProfile);
            groupBox1.Location = new System.Drawing.Point(12, 382);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(989, 245);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Information";
            // 
            // btnLogout
            // 
            btnLogout.Location = new System.Drawing.Point(551, 178);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(119, 38);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(834, 178);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(128, 38);
            button2.TabIndex = 10;
            button2.Text = "Check Active";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnHistory
            // 
            btnHistory.Location = new System.Drawing.Point(834, 102);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new System.Drawing.Size(128, 36);
            btnHistory.TabIndex = 9;
            btnHistory.Text = "History Booked";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(551, 43);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(119, 40);
            button1.TabIndex = 8;
            button1.Text = "Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dateTimePicker2.Location = new System.Drawing.Point(187, 189);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(279, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker1.Location = new System.Drawing.Point(187, 111);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(279, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(187, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(284, 27);
            textBox2.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(64, 196);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(77, 20);
            label6.TabIndex = 4;
            label6.Text = "Book time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(64, 116);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(77, 20);
            label5.TabIndex = 3;
            label5.Text = "Book date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(78, 53);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(50, 20);
            label4.TabIndex = 2;
            label4.Text = "Phone";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new System.Drawing.Point(12, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(989, 283);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 75;
            // 
            // Column2
            // 
            Column2.HeaderText = "Studtio";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 175;
            // 
            // Column3
            // 
            Column3.HeaderText = "Name";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Degree";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Phone ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 175;
            // 
            // Column6
            // 
            Column6.HeaderText = "Address";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(174, 20);
            label1.TabIndex = 7;
            label1.Text = "Choose Artist to booking";
            // 
            // labID
            // 
            labID.AutoSize = true;
            labID.Location = new System.Drawing.Point(855, 28);
            labID.Name = "labID";
            labID.Size = new System.Drawing.Size(24, 20);
            labID.TabIndex = 8;
            labID.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(902, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(81, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(407, 22);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Name";
            textBox3.Size = new System.Drawing.Size(248, 27);
            textBox3.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(661, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(94, 29);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(360, 25);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(30, 20);
            label3.TabIndex = 12;
            label3.Text = "\t🔎︎";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.Maroon;
            label2.Location = new System.Drawing.Point(24, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 20);
            label2.TabIndex = 13;
            label2.Text = "label2";
            // 
            // frmBookingTatoo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1027, 661);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btnSearch);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(labID);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "frmBookingTatoo";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmBookingTatoo";
            Load += frmBookingTatoo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label2;
    }
}