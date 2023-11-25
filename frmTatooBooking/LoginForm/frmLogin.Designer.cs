namespace frmTatooBooking.Login
{
    partial class frmLogin
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
            btnLoginAdmin = new System.Windows.Forms.Button();
            btnLoginStaff = new System.Windows.Forms.Button();
            btnLoginUser = new System.Windows.Forms.Button();
            ucLoginStaff1 = new ucLoginStaff();
            ucLoginAdmin1 = new ucLoginAdmin();
            ucLoginUser1 = new ucLoginUser();
            btnLoginArtist = new System.Windows.Forms.Button();
            ucLoginArtist1 = new LoginForm.ucLoginArtist();
            SuspendLayout();
            // 
            // btnLoginAdmin
            // 
            btnLoginAdmin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            btnLoginAdmin.ForeColor = System.Drawing.Color.MediumTurquoise;
            btnLoginAdmin.Location = new System.Drawing.Point(112, 188);
            btnLoginAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new System.Drawing.Size(217, 132);
            btnLoginAdmin.TabIndex = 0;
            btnLoginAdmin.Text = "Login as Admin";
            btnLoginAdmin.UseVisualStyleBackColor = true;
            btnLoginAdmin.Click += btnLoginAdmin_Click;
            // 
            // btnLoginStaff
            // 
            btnLoginStaff.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            btnLoginStaff.ForeColor = System.Drawing.Color.MediumTurquoise;
            btnLoginStaff.Location = new System.Drawing.Point(112, 16);
            btnLoginStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLoginStaff.Name = "btnLoginStaff";
            btnLoginStaff.Size = new System.Drawing.Size(217, 132);
            btnLoginStaff.TabIndex = 1;
            btnLoginStaff.Text = "Login as Staff";
            btnLoginStaff.UseVisualStyleBackColor = true;
            btnLoginStaff.Click += btnLoginStaff_Click;
            // 
            // btnLoginUser
            // 
            btnLoginUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            btnLoginUser.ForeColor = System.Drawing.Color.MediumTurquoise;
            btnLoginUser.Location = new System.Drawing.Point(378, 16);
            btnLoginUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLoginUser.Name = "btnLoginUser";
            btnLoginUser.Size = new System.Drawing.Size(217, 132);
            btnLoginUser.TabIndex = 2;
            btnLoginUser.Text = "Login as User";
            btnLoginUser.UseVisualStyleBackColor = true;
            btnLoginUser.Click += btnLoginUser_Click;
            // 
            // ucLoginStaff1
            // 
            ucLoginStaff1.Location = new System.Drawing.Point(55, 328);
            ucLoginStaff1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            ucLoginStaff1.Name = "ucLoginStaff1";
            ucLoginStaff1.Size = new System.Drawing.Size(584, 325);
            ucLoginStaff1.TabIndex = 3;
            // 
            // ucLoginAdmin1
            // 
            ucLoginAdmin1.Location = new System.Drawing.Point(55, 328);
            ucLoginAdmin1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            ucLoginAdmin1.Name = "ucLoginAdmin1";
            ucLoginAdmin1.Size = new System.Drawing.Size(584, 325);
            ucLoginAdmin1.TabIndex = 4;
            // 
            // ucLoginUser1
            // 
            ucLoginUser1.Location = new System.Drawing.Point(55, 328);
            ucLoginUser1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            ucLoginUser1.Name = "ucLoginUser1";
            ucLoginUser1.Size = new System.Drawing.Size(584, 325);
            ucLoginUser1.TabIndex = 5;
            // 
            // btnLoginArtist
            // 
            btnLoginArtist.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            btnLoginArtist.ForeColor = System.Drawing.Color.MediumTurquoise;
            btnLoginArtist.Location = new System.Drawing.Point(378, 188);
            btnLoginArtist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLoginArtist.Name = "btnLoginArtist";
            btnLoginArtist.Size = new System.Drawing.Size(217, 132);
            btnLoginArtist.TabIndex = 6;
            btnLoginArtist.Text = "Login as Artist";
            btnLoginArtist.UseVisualStyleBackColor = true;
            btnLoginArtist.Click += btnLoginArtist_Click;
            // 
            // ucLoginArtist1
            // 
            ucLoginArtist1.Location = new System.Drawing.Point(55, 328);
            ucLoginArtist1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            ucLoginArtist1.Name = "ucLoginArtist1";
            ucLoginArtist1.Size = new System.Drawing.Size(584, 325);
            ucLoginArtist1.TabIndex = 7;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(697, 664);
            Controls.Add(ucLoginArtist1);
            Controls.Add(btnLoginArtist);
            Controls.Add(ucLoginUser1);
            Controls.Add(ucLoginAdmin1);
            Controls.Add(ucLoginStaff1);
            Controls.Add(btnLoginUser);
            Controls.Add(btnLoginStaff);
            Controls.Add(btnLoginAdmin);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnLoginAdmin;
        private System.Windows.Forms.Button btnLoginStaff;
        private System.Windows.Forms.Button btnLoginUser;
        private ucLoginStaff ucLoginStaff1;
        private ucLoginAdmin ucLoginAdmin1;
        private ucLoginUser ucLoginUser1;
        private System.Windows.Forms.Button btnLoginArtist;
        private LoginForm.ucLoginArtist ucLoginArtist1;
    }
}