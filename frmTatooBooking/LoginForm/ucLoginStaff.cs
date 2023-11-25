using System;
using System.Windows.Forms;
using TatooBookingLibrary.Models;
using TatooBookingLibrary.Repository;

namespace frmTatooBooking.Login
{
    public partial class ucLoginStaff : UserControl
    {
        StudioStaffRepository studioStaffRepository = new StudioStaffRepository();

        public ucLoginStaff()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string emailLogin = txtUsername.Text;
            string passwordlLogin = txtPassword.Text;
            if (emailLogin == "")
            {
                MessageBox.Show("Please input email!");
            }
            else if (passwordlLogin == "")
            {
                MessageBox.Show("Please input password!");
            }
            else
            {
                StudioStaff studioStaff = studioStaffRepository.CheckLogin(emailLogin, passwordlLogin);
                try
                {
                    if (studioStaff != null)
                    {
                        frmStaffDashBoard f = new frmStaffDashBoard(studioStaff.Studio.Id);
                        f.ShowDialog();
                    }
                }
                catch
                {
                    DialogResult d;
                    d = MessageBox.Show("Your account is wrong, please input again",
                                    "Artist Management - Login", MessageBoxButtons.OK, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}
