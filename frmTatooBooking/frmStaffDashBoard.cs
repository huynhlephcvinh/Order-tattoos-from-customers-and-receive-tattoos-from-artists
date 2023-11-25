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

namespace frmTatooBooking
{
    public partial class frmStaffDashBoard : Form
    {
        public int studioID { get; set; }
        public frmStaffDashBoard(int studioID)
        {
            this.studioID = studioID;
            InitializeComponent();
        }

        private void btnTatooManagement_Click(object sender, EventArgs e)
        {
            frmTatooForStaff f = new frmTatooForStaff();
            f.ShowDialog();
        }

        private void btnArtistManagement_Click(object sender, EventArgs e)
        {
            frmArtistManagememt f = new frmArtistManagememt(studioID);
            f.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
