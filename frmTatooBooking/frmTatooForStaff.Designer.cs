namespace frmTatooBooking
{
    partial class frmTatooForStaff
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
            Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnAdd = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label6 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            btnUpdate = new System.Windows.Forms.Button();
            btnBrowse = new System.Windows.Forms.Button();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            textBox3 = new System.Windows.Forms.TextBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            Description = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnDelete = new System.Windows.Forms.Button();
            Cancel = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new System.Drawing.Point(34, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(919, 460);
            dataGridView1.TabIndex = 0;
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
            Column6.Width = 300;
            // 
            // Column7
            // 
            Column7.FillWeight = 600F;
            Column7.HeaderText = "Status";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 50;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(417, 600);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(105, 39);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnBrowse);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(Description);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new System.Drawing.Point(986, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(680, 685);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Update";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(375, 370);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(37, 20);
            label6.TabIndex = 17;
            label6.Text = "Path";
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(438, 367);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(222, 27);
            textBox4.TabIndex = 16;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(516, 629);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new System.Drawing.Point(207, 26);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(140, 63);
            btnBrowse.TabIndex = 14;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(230, 634);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(51, 24);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Off";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(96, 634);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(49, 24);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "On";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(438, 505);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(222, 27);
            textBox3.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(438, 433);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(222, 28);
            comboBox1.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(96, 464);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(251, 114);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(96, 400);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(251, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(96, 333);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(163, 27);
            textBox1.TabIndex = 7;
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new System.Drawing.Point(6, 522);
            Description.Name = "Description";
            Description.Size = new System.Drawing.Size(85, 20);
            Description.TabIndex = 6;
            Description.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(17, 634);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 20);
            label5.TabIndex = 5;
            label5.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(375, 512);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 20);
            label4.TabIndex = 4;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(359, 441);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 20);
            label3.TabIndex = 3;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(17, 403);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(17, 333);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.Location = new System.Drawing.Point(359, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(301, 312);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(826, 595);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 39);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new System.Drawing.Point(2150, 774);
            Cancel.Name = "Cancel";
            Cancel.Size = new System.Drawing.Size(94, 39);
            Cancel.TabIndex = 4;
            Cancel.Text = "u";
            Cancel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(64, 600);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 39);
            button1.TabIndex = 5;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmTatooForStaff
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1689, 743);
            Controls.Add(button1);
            Controls.Add(Cancel);
            Controls.Add(btnDelete);
            Controls.Add(groupBox1);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "frmTatooForStaff";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmTatooForStaff";
            Load += frmTatooForStaff_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button button1;
    }
}