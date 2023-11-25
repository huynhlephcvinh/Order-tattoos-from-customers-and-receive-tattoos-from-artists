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

namespace frmTatooBooking
{
    public partial class frmCheckActiveFromArtist : Form
    {
        public TatooBookingLibrary.Models.User getUser { get; set; }

        public static IBookingTatooRepository bookingTatooRepository = new BookingTatooRepository();
        public static IArtistRepository artistRepository = new ArtistRepository();
        public frmCheckActiveFromArtist()
        {
            InitializeComponent();
        }

        private void frmCheckActiveFromArtist_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            LoadData();
        }

        public void LoadData()
        {
            button1.Enabled = false;
            dataGridView1.Rows.Clear();
            var bookingTatoos = bookingTatooRepository.GetBookingTatoos().Where(x => x.UsersId == getUser.Id && x.Status == 1);
            foreach (BookingTatoo bookingTatoo in bookingTatoos)
            {
                bookingTatoo.Users = getUser;
                dataGridView1.Rows.Add(bookingTatoo.Id, bookingTatoo.Users.Name, bookingTatoo.DateCreate.Value.ToString("dd-MM-yyyy"), bookingTatoo.UsersPhone, bookingTatoo.UsersBookDate.Value.ToString("dd-MM-yyyy"), bookingTatoo.UsersBookTime.Value.Hours, bookingTatoo.ArtistId);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Column7"].Value.ToString();
            }
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int artistID = int.Parse(textBox2.Text);
            int id = int.Parse(textBox1.Text);
            // Xet status == 2
            var booktatoo = bookingTatooRepository.GetBookingTatoos().SingleOrDefault(x => x.Id == id);
            var Artist = artistRepository.GetArtist(artistID);
            if (booktatoo == null)
            {
                return;
            }
            frmBookingService bookingService = new frmBookingService()
            {
                artist = Artist,
                user = getUser,
                bookingTatoo = booktatoo
            };
            bookingService.Show();
            this.Close();

        }

        private void btnHistoryService_Click(object sender, EventArgs e)
        {
            frmHistoryBookService bookingService = new frmHistoryBookService()
            {
                user = getUser
            };
            bookingService.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
