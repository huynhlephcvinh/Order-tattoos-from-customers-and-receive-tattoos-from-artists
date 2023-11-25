namespace frmTatooBooking
{
    partial class frmBillFroCustomer
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            button1 = new System.Windows.Forms.Button();
            checkBox2 = new System.Windows.Forms.CheckBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new System.Drawing.Point(44, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(752, 357);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Customer";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Artist";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tattoo";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 175;
            // 
            // Column5
            // 
            Column5.HeaderText = "Price";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Status";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(44, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(113, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(82, 27);
            textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new System.Drawing.Point(40, 472);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(756, 215);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter infor bill for customer";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(624, 157);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 40);
            button1.TabIndex = 25;
            button1.Text = "Done";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new System.Drawing.Point(357, 46);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(69, 24);
            checkBox2.TabIndex = 24;
            checkBox2.Text = "Day 3";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(184, 45);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(69, 24);
            checkBox1.TabIndex = 23;
            checkBox1.Text = "Day 2";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker3.Location = new System.Drawing.Point(357, 84);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new System.Drawing.Size(114, 27);
            dateTimePicker3.TabIndex = 22;
            dateTimePicker3.Value = new System.DateTime(1800, 11, 3, 16, 35, 0, 0);
            dateTimePicker3.Visible = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker2.Location = new System.Drawing.Point(182, 84);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(114, 27);
            dateTimePicker2.TabIndex = 21;
            dateTimePicker2.Value = new System.DateTime(1800, 11, 3, 16, 34, 0, 0);
            dateTimePicker2.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker1.Location = new System.Drawing.Point(32, 84);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(110, 27);
            dateTimePicker1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(44, 46);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 20);
            label2.TabIndex = 19;
            label2.Text = "Day 1";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(529, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(143, 27);
            textBox2.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(577, 46);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 20);
            label4.TabIndex = 17;
            label4.Text = "Price";
            // 
            // frmBillFroCustomer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(825, 727);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frmBillFroCustomer";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmBillFroCustomer";
            Load += frmBillFroCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}