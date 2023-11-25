using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TatooBookingLibrary.Models;
using TatooBookingLibrary.Repository;

namespace frmTatooBooking
{
    public partial class frmUpdateProfileCustomer : Form
    {
        public User GetUserDetail { get; set; }
        public IUserRepository userRepository { get; set; }
        // public IUserRepository userRepository = new UserRepository();
        public frmUpdateProfileCustomer()
        {
            InitializeComponent();
        }

        private void frmUpdateProfileCustomer_Load(object sender, EventArgs e)
        {
            textBox1.Text = GetUserDetail.Id.ToString();
            textBox2.Text = GetUserDetail.Name.ToString();
            textBox3.Text = GetUserDetail.Email.ToString();
            textBox4.Text = GetUserDetail.Password.ToString();
            label1.Visible = false;
            textBox1.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text.Equals(""))
                {
                    MessageBox.Show("Name is empty");
                    return;
                }
                if (textBox3.Text.Equals(""))
                {
                    MessageBox.Show("Email is empty");
                    return;
                }
                if (textBox4.Text.Equals(""))
                {
                    MessageBox.Show("Password is empty");
                    return;
                }
                User user = GetUserDetail;
                user.Name = textBox2.Text;
                user.Email = textBox3.Text;
                user.Password = textBox4.Text;
                userRepository.UpdateUser(user);
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox4.PasswordChar = '\0';

            }
            else
            {
                textBox4.PasswordChar = '*';
            }
        }
    }
}
