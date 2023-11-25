namespace frmTatooBooking
{
    partial class frmUpdateProfieArtist
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
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            textBox6 = new System.Windows.Forms.TextBox();
            btnUpdate = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            checkBox1 = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(49, 77);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(49, 139);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(51, 200);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Degree";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(51, 273);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(49, 335);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(49, 404);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(70, 20);
            label6.TabIndex = 5;
            label6.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(130, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(277, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(130, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(277, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(130, 193);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(277, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(130, 266);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(277, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(130, 335);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(277, 27);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(130, 401);
            textBox6.Name = "textBox6";
            textBox6.PasswordChar = '*';
            textBox6.Size = new System.Drawing.Size(277, 27);
            textBox6.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnUpdate.Location = new System.Drawing.Point(49, 529);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClose
            // 
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.Location = new System.Drawing.Point(313, 529);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 29);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(130, 447);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(77, 24);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "On/Off";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // frmUpdateProfieArtist
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(473, 597);
            Controls.Add(checkBox1);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUpdateProfieArtist";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmUpdateProfieArtist";
            Load += frmUpdateProfieArtist_Load;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}