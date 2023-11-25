namespace frmTatooBooking
{
    partial class frmCheckActiveFromArtist
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
            Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            btnHistoryService = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new System.Drawing.Point(12, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(801, 416);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Customer";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Date Create";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Phone";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Date book";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Time Book";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Artist";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Visible = false;
            Column7.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(384, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(414, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(43, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(11, 118);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(427, 20);
            label2.TabIndex = 3;
            label2.Text = " Booking artist will display when artist and customer contacted ";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(634, 100);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(179, 35);
            button1.TabIndex = 4;
            button1.Text = "Go to Book Service";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(12, 63);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnHistoryService
            // 
            btnHistoryService.Location = new System.Drawing.Point(634, 45);
            btnHistoryService.Name = "btnHistoryService";
            btnHistoryService.Size = new System.Drawing.Size(179, 36);
            btnHistoryService.TabIndex = 6;
            btnHistoryService.Text = "History Booking Service";
            btnHistoryService.UseVisualStyleBackColor = true;
            btnHistoryService.Click += btnHistoryService_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(482, 15);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(44, 20);
            label3.TabIndex = 7;
            label3.Text = "Artist";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(538, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(42, 27);
            textBox2.TabIndex = 8;
            // 
            // frmCheckActiveFromArtist
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(831, 570);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(btnHistoryService);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frmCheckActiveFromArtist";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCheckActiveFromArtist";
            Load += frmCheckActiveFromArtist_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnHistoryService;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}