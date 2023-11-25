using System;
using System.Windows.Forms;
using TatooBookingLibrary.DataAccessObject;
using TatooBookingLibrary.Models;

namespace frmTatooBooking.Login
{
    public partial class ucLoginAdmin : UserControl
    {
        public ucLoginAdmin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string loginUsername = txtUsername.Text;
            string loginPassword = txtPassword.Text;
            if (loginUsername == "")
            {
                MessageBox.Show("Please input email!");
            }
            else if (loginPassword == "")
            {
                MessageBox.Show("Please input password!");
            }
            else
            {
                User userLogin = new User();
                userLogin = UserDAO.CheckLogin(loginUsername, loginPassword);
                if (userLogin != null)
                {
                    if (userLogin.Role == 3)
                    {
                        frmStudioStaffManagement f = new frmStudioStaffManagement();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("You have no permission to do this!");
                    }
                }
                else
                {
                    MessageBox.Show("Your account was not registered!");
                }
            }
        }
    }
}
