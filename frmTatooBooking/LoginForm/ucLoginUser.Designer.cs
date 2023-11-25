namespace frmTatooBooking.Login
{
    partial class ucLoginUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            btnSubmit = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            btnSignUp = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbl.Location = new System.Drawing.Point(223, 53);
            lbl.Name = "lbl";
            lbl.Size = new System.Drawing.Size(165, 32);
            lbl.TabIndex = 11;
            lbl.Text = "Login as User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(122, 161);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 20);
            label2.TabIndex = 10;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(210, 157);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(250, 27);
            txtPassword.TabIndex = 9;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new System.Drawing.Point(163, 225);
            btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(113, 47);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(122, 123);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 20);
            label1.TabIndex = 7;
            label1.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(210, 119);
            txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(250, 27);
            txtUsername.TabIndex = 6;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new System.Drawing.Point(297, 225);
            btnSignUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new System.Drawing.Size(113, 47);
            btnSignUp.TabIndex = 12;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // ucLoginUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnSignUp);
            Controls.Add(lbl);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ucLoginUser";
            Size = new System.Drawing.Size(584, 325);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSignUp;
    }
}
