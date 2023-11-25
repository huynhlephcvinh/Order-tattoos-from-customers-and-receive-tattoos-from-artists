namespace frmTatooBooking
{
    partial class frmAddOrUpdateTatooStaff
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            textBox3 = new System.Windows.Forms.TextBox();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnBrowse = new System.Windows.Forms.Button();
            textBox4 = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(107, 107);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(71, 276);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(87, 408);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(107, 496);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(107, 579);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 20);
            label5.TabIndex = 4;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(784, 181);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(51, 20);
            label6.TabIndex = 5;
            label6.Text = "Image";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(188, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(270, 27);
            textBox2.TabIndex = 6;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(188, 181);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(270, 195);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(188, 400);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(270, 28);
            comboBox1.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(188, 489);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(270, 27);
            textBox3.TabIndex = 9;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new System.Drawing.Point(188, 575);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(49, 24);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "On";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(341, 575);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(51, 24);
            radioButton2.TabIndex = 11;
            radioButton2.Text = "Off";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.Location = new System.Drawing.Point(653, 212);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(320, 232);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(625, 570);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(879, 570);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new System.Drawing.Point(766, 459);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(96, 57);
            btnBrowse.TabIndex = 17;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(682, 107);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(291, 27);
            textBox4.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(567, 110);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(83, 20);
            label8.TabIndex = 20;
            label8.Text = "Image Path";
            // 
            // frmAddOrUpdateTatooStaff
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1022, 679);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(btnBrowse);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(pictureBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddOrUpdateTatooStaff";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmAddOrUpdateTatooStaff";
            Load += frmAddOrUpdateTatooStaff_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
    }
}