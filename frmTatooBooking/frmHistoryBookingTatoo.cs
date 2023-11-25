using Microsoft.VisualBasic.ApplicationServices;
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
using User = TatooBookingLibrary.Models.User;

namespace frmTatooBooking
{
    public partial class frmHistoryBookingTatoo : Form
    {
        public User user { get; set; }

        public static IBookingTatooRepository bookingTatooRepository = new BookingTatooRepository();
        public static IArtistRepository artistRepository = new ArtistRepository();
        public frmHistoryBookingTatoo()
        {
            InitializeComponent();
        }

        private void frmHistoryBookingTatoo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dataGridView1.Rows.Clear();
            var bookingTatoos = bookingTatooRepository.GetBookingTatoos().Where(x => x.UsersId == user.Id && x.Status == 2);
            foreach (BookingTatoo bookingTatoo in bookingTatoos)
            {
                bookingTatoo.Artist = artistRepository.GetArtist((int)bookingTatoo.ArtistId);
                dataGridView1.Rows.Add(bookingTatoo.Id, bookingTatoo.Artist.Name, bookingTatoo.DateCreate.Value.ToString("dd-MM-yyyy"), bookingTatoo.UsersPhone, bookingTatoo.UsersBookDate.Value.ToString("dd-MM-yyyy"), bookingTatoo.UsersBookTime.Value.Hours);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
