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
    public partial class frmSignUp : Form
    {
        IUserRepository userRepository = new UserRepository();
        List<User> users = new List<User>();

        public frmSignUp()
        {

            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            users = userRepository.GetUsers();
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string FullName = txtFullname.Text;
            Boolean check = true;
            DialogResult d;
            foreach (User user in users)
            {
                if (email.Trim().Equals(user.Email.Trim()))
                {
                    d = MessageBox.Show("This email has already exist!",
                                        "Register", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                    check = false;
                    break;
                }
            }
            if (check == true)
            {
                User user1 = new User
                {
                    Name = FullName,
                    Email = email,
                    Password = password,
                    Role = 1,
                    Status = 1
                };
                userRepository.SaveUser(user1);
                d = MessageBox.Show("Your account is ready to use!",
                                    "Register", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                Close();
            }

        }
    }
}
