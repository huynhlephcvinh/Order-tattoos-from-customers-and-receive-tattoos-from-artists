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
    public partial class frmBillForAdmin : Form
    {
        public static IUserRepository userRepository = new UserRepository();
        public static IArtistRepository artistRepository = new ArtistRepository();
        public static ITatooRepository tatooRepository = new TatooRepository();
        public static IBookingServiceRepository bookingServiceRepository = new BookingServiceRepository();
        public frmBillForAdmin()
        {
            InitializeComponent();
        }

        private void frmBillForAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dataGridView1.Rows.Clear();
            var services = bookingServiceRepository.GetBookingServices().Where(x => x.Status == 1);
            foreach (BookingService bookingService in services)
            {
                bookingService.Artist = artistRepository.GetArtist((int)bookingService.ArtistId);
                bookingService.Users = userRepository.GetUsers().SingleOrDefault(x => x.Id == bookingService.UsersId);
                bookingService.Tatoo = tatooRepository.GetTatoos().SingleOrDefault(x => x.Id == bookingService.TatooId);
                dataGridView1.Rows.Add(bookingService.Id, bookingService.Users.Name, bookingService.Artist.Name, bookingService.Tatoo.TatooName, bookingService.InkDay1.ToString("dd-MM-yyyy"), bookingService.InkDay2, bookingService.InkDay3, bookingService.TotalPrice);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
