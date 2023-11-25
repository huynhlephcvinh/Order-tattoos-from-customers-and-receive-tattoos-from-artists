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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frmTatooBooking.LoginForm
{
    public partial class ucLoginArtist : UserControl
    {
        IArtistRepository artistRepository = new ArtistRepository();

        public ucLoginArtist()
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
                var artist = artistRepository.GetAllArtists()
                .Where(a => a.Email == txtUsername.Text.Trim() && a.Password == txtPassword.Text.Trim()).FirstOrDefault();
                if (artist != null)
                {
                    frmArtistDashboard frmArtistDashboard = new frmArtistDashboard()
                    {
                        getArtist = artist
                    };
                    frmArtistDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your account was not registered!");
                }
            }
        }
    }
}
