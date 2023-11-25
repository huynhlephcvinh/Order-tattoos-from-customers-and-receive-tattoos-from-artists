namespace frmTatooBooking
{
    partial class frmBookingService
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            button1 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new System.Drawing.Point(23, 611);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(996, 162);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Information";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(397, 51);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(170, 72);
            button1.TabIndex = 8;
            button1.Text = "Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(100, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(143, 27);
            textBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(144, 51);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 70);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(136, 20);
            label5.TabIndex = 2;
            label5.Text = "Choose one tattoo ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Indigo;
            label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            label6.Location = new System.Drawing.Point(12, 22);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(50, 20);
            label6.TabIndex = 3;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(885, 22);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(22, 20);
            label7.TabIndex = 4;
            label7.Text = "id";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(913, 19);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(53, 27);
            textBox2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new System.Drawing.Point(22, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(996, 498);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.FillWeight = 600F;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.FillWeight = 600F;
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.FillWeight = 600F;
            Column3.HeaderText = "Description";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.FillWeight = 600F;
            Column4.HeaderText = "Category";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.FillWeight = 600F;
            Column5.HeaderText = "Price";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.FillWeight = 600F;
            Column6.HeaderText = "Image";
            Column6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Column6.Width = 350;
            // 
            // Column7
            // 
            Column7.FillWeight = 600F;
            Column7.HeaderText = "Status";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Visible = false;
            Column7.Width = 50;
            // 
            // frmBookingService
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1039, 785);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Name = "frmBookingService";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmBookingService";
            Load += frmBookingService_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}