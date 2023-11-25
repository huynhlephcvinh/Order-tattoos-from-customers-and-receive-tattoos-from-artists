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
    public partial class frmHistoryBookService : Form
    {
        public User user { get; set; }
        public IBookingServiceRepository bookingServiceRepository = new BookingServiceRepository();
        public IArtistRepository artistRepository = new ArtistRepository();
        public ITatooRepository tatooRepository = new TatooRepository();

        public frmHistoryBookService()
        {
            InitializeComponent();
        }

        private void frmHistoryBookService_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dataGridView1.Rows.Clear();
            var bookingServices = bookingServiceRepository.GetBookingServices().Where(x => x.UsersId == user.Id);
            foreach (BookingService bookingTatoo in bookingServices)
            {
                bookingTatoo.Artist = artistRepository.GetArtist((int)bookingTatoo.ArtistId);
                bookingTatoo.Tatoo = tatooRepository.GetTatoos().SingleOrDefault(x => x.Id == bookingTatoo.TatooId);
                dataGridView1.Rows.Add(bookingTatoo.Id, bookingTatoo.Artist.Name, bookingTatoo.Tatoo.TatooName, bookingTatoo.TotalPrice);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
