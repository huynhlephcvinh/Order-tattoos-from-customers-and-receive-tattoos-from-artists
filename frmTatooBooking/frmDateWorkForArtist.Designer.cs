namespace frmTatooBooking
{
    partial class frmDateWorkForArtist
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
            components = new System.ComponentModel.Container();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(44, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(44, 116);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(29, 194);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Start Hours";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(35, 273);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "End Hours";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(124, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dateTimePicker2.Location = new System.Drawing.Point(124, 194);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(250, 27);
            dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dateTimePicker3.Location = new System.Drawing.Point(124, 268);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new System.Drawing.Size(250, 27);
            dateTimePicker3.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(44, 363);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(280, 363);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker1.Location = new System.Drawing.Point(124, 116);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // frmDateWorkForArtist
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(428, 455);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDateWorkForArtist";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmDateWorkForArtist";
            Load += frmDateWorkForArtist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}