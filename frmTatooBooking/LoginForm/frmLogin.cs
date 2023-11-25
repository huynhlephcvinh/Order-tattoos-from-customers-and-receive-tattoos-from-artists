using frmTatooBooking.LoginForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTatooBooking.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLoginStaff_Click(object sender, EventArgs e)
        {
            ucLoginAdmin1.Hide();
            ucLoginStaff1.Show();
            ucLoginUser1.Hide();
            ucLoginArtist1.Hide();
        }

        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            ucLoginAdmin1.Hide();
            ucLoginStaff1.Hide();
            ucLoginUser1.Show();
            ucLoginArtist1.Hide();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            ucLoginAdmin1.Show();
            ucLoginStaff1.Hide();
            ucLoginUser1.Hide();
            ucLoginArtist1.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ucLoginAdmin1.Hide();
            ucLoginStaff1.Hide();
            ucLoginUser1.Hide();
            ucLoginArtist1.Hide();
        }

        private void btnLoginArtist_Click(object sender, EventArgs e)
        {
            ucLoginAdmin1.Hide();
            ucLoginStaff1.Hide();
            ucLoginUser1.Hide();
            ucLoginArtist1.Show();
        }
    }
}
