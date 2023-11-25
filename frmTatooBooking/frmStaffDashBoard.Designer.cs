namespace frmTatooBooking
{
    partial class frmStaffDashBoard
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
            btnArtistManagement = new System.Windows.Forms.Button();
            btnTatooManagement = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnArtistManagement
            // 
            btnArtistManagement.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnArtistManagement.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnArtistManagement.Location = new System.Drawing.Point(434, 68);
            btnArtistManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnArtistManagement.Name = "btnArtistManagement";
            btnArtistManagement.Size = new System.Drawing.Size(226, 151);
            btnArtistManagement.TabIndex = 0;
            btnArtistManagement.Text = "Managing Artist";
            btnArtistManagement.UseVisualStyleBackColor = false;
            btnArtistManagement.Click += btnArtistManagement_Click;
            // 
            // btnTatooManagement
            // 
            btnTatooManagement.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnTatooManagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTatooManagement.Location = new System.Drawing.Point(85, 68);
            btnTatooManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnTatooManagement.Name = "btnTatooManagement";
            btnTatooManagement.Size = new System.Drawing.Size(226, 151);
            btnTatooManagement.TabIndex = 1;
            btnTatooManagement.Text = "Managing Tatoo";
            btnTatooManagement.UseVisualStyleBackColor = false;
            btnTatooManagement.Click += btnTatooManagement_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnLogout.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLogout.Location = new System.Drawing.Point(258, 304);
            btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(226, 73);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmStaffDashBoard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(749, 405);
            Controls.Add(btnLogout);
            Controls.Add(btnTatooManagement);
            Controls.Add(btnArtistManagement);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmStaffDashBoard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Staff Dash Board";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnArtistManagement;
        private System.Windows.Forms.Button btnTatooManagement;
        private System.Windows.Forms.Button btnLogout;
    }
}