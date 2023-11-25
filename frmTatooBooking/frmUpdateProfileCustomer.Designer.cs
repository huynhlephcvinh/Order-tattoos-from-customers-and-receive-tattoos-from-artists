namespace frmTatooBooking
{
    partial class frmUpdateProfileCustomer
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
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            btnUpdate = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            checkBox1 = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(262, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(49, 98);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(49, 187);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(28, 283);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(310, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(116, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(266, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(116, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(266, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(116, 283);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new System.Drawing.Size(266, 27);
            textBox4.TabIndex = 7;
            // 
            // btnUpdate
            // 
            btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnUpdate.Location = new System.Drawing.Point(28, 402);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClose
            // 
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.Location = new System.Drawing.Point(301, 402);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 29);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(116, 327);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(77, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "On/Off";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // frmUpdateProfileCustomer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(443, 527);
            Controls.Add(checkBox1);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUpdateProfileCustomer";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Update Profile";
            Load += frmUpdateProfileCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}