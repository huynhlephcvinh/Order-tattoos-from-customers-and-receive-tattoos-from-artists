using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TatooBookingLibrary.Repository;

namespace frmTatooBooking.Login
{
    public partial class ucLoginUser : UserControl
    {
        public static IUserRepository userRepository = new UserRepository();
        public static IArtistRepository artistRepository = new ArtistRepository();

        public ucLoginUser()
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
                var user = userRepository.GetUsers()
            .Where(a => a.Email == txtUsername.Text.Trim() && a.Password == txtPassword.Text.Trim()).FirstOrDefault();
                if (user != null)
                {
                    if (user.Role == 1)
                    {
                        frmBookingTatoo frmBookingTatoo = new frmBookingTatoo()
                        {
                            GetUser = user,
                            UserRepository = userRepository
                        };
                        frmBookingTatoo.Show();
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp frmSignUp = new frmSignUp();
            frmSignUp.Show();
        }
    }
}
