namespace frmTatooBooking
{
    partial class frmSignUp
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
            btnSubmit = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtFullname = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new System.Drawing.Point(120, 276);
            btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(86, 31);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(64, 71);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 20);
            label1.TabIndex = 1;
            label1.Text = "Your Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(64, 133);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(64, 197);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(198, 129);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(217, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtFullname
            // 
            txtFullname.Location = new System.Drawing.Point(198, 67);
            txtFullname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new System.Drawing.Size(217, 27);
            txtFullname.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(198, 193);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(217, 27);
            txtPassword.TabIndex = 6;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(267, 276);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(86, 31);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmSignUp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(478, 372);
            Controls.Add(btnCancel);
            Controls.Add(txtPassword);
            Controls.Add(txtFullname);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmSignUp";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmSignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCancel;
    }
}