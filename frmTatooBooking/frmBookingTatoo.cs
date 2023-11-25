using frmTatooBooking.Login;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TatooBookingLibrary.Models;
using TatooBookingLibrary.Repository;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace frmTatooBooking
{
    public partial class frmBookingTatoo : Form
    {
        public TatooBookingLibrary.Models.User GetUser { get; set; }
        public IUserRepository UserRepository { get; set; }
        public static IStudioRepository StudioRepository = new StudioRepository();
        public static IArtistRepository ArtistRepository = new ArtistRepository();
        public static IDateWorkForArtistRepository dateWorkForArtistRepository = new DateWorkForArtistRepository();
        public static IBookingTatooRepository BookingTatooRepository = new BookingTatooRepository();

        public frmBookingTatoo()
        {
            InitializeComponent();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            frmUpdateProfileCustomer frmUpdateProfileCustomer = new frmUpdateProfileCustomer()
            {
                GetUserDetail = GetUser,
                userRepository = UserRepository
            };
            if (frmUpdateProfileCustomer.ShowDialog() == DialogResult.OK)
            {
                LoadData();

            }


        }

        private void frmBookingTatoo_Load(object sender, EventArgs e)
        {
            label2.Text = "Welcome customer: " + GetUser.Name;
            labID.Visible = false;
            textBox1.Visible = false;
            LoadData();
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH"; // Only use hours and minutes
            dateTimePicker2.ShowUpDown = true;

        }

        public void LoadData()
        {
            button1.Enabled = false;
            dataGridView1.Rows.Clear();
            List<Artist> artists = ArtistRepository.GetArtists();
            foreach (Artist artist in artists)
            {
                artist.Studio = StudioRepository.GetStudio((int)artist.StudioId);
                dataGridView1.Rows.Add(artist.Id, artist.Studio.Name, artist.Name, artist.Degree, artist.Phone, artist.Address);
            }

        }
        public void LoadForm()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
            }
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text.Equals(""))
                {
                    MessageBox.Show("Phone is empty");
                    return;
                }
                Regex regex = new Regex(@"^\d$");
                if (regex.IsMatch(textBox2.Text))
                {
                    MessageBox.Show("Phone is digit");
                    return;
                }
                var dateWorkForArtists = dateWorkForArtistRepository.GetDateWorkForArtists().Where(x => x.ArtistId == int.Parse(textBox1.Text));
                foreach (DateWorkForArtist date in dateWorkForArtists)
                {
                    if (date.WorkDate.Value.ToString("dd-MM-yyyy").Equals(dateTimePicker1.Value.ToString("dd-MM-yyyy")))
                    {
                        if (date.StartWorkHour.Value.Hours > dateTimePicker2.Value.TimeOfDay.Hours || date.EndWorkHour.Value.Hours < dateTimePicker2.Value.TimeOfDay.Hours)
                        {
                            MessageBox.Show("Time of Artist bussy");
                            return;
                        }
                        else if (date.StartWorkHour.Value.Hours < dateTimePicker2.Value.TimeOfDay.Hours && date.EndWorkHour.Value.Hours > dateTimePicker2.Value.TimeOfDay.Hours)
                        {
                            BookingTatoo bookingTatoo = new BookingTatoo();
                            bookingTatoo.UsersId = GetUser.Id;
                            bookingTatoo.ArtistId = int.Parse(textBox1.Text);
                            bookingTatoo.DateCreate = DateTime.Now;
                            bookingTatoo.UsersPhone = textBox2.Text;
                            bookingTatoo.UsersBookDate = dateTimePicker1.Value;
                            bookingTatoo.UsersBookTime = dateTimePicker2.Value.TimeOfDay;
                            bookingTatoo.Status = 0;
                            BookingTatooRepository.CreateBookingTatoo(bookingTatoo);
                            MessageBox.Show("You can contact Artist and you wait active from Artist");
                            return;
                        }
                    }

                }
                MessageBox.Show("Date of Artist bussy");
                return;


            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string text = textBox3.Text;
            LoadDataSearch(text);
        }

        public void LoadDataSearch(string text)
        {
            button1.Enabled = false;
            dataGridView1.Rows.Clear();
            List<Artist> artists = ArtistRepository.GetArtists();
            foreach (Artist artist in artists)
            {
                if (artist.Name.ToLower().Contains(text.ToLower()))
                {
                    artist.Studio = StudioRepository.GetStudio((int)artist.StudioId);
                    dataGridView1.Rows.Add(artist.Id, artist.Studio.Name, artist.Name, artist.Degree, artist.Phone, artist.Address);
                }
            }

        }
        //Check Active
        private void button2_Click(object sender, EventArgs e)
        {
            frmCheckActiveFromArtist frmCheckActiveFromArtist = new frmCheckActiveFromArtist()
            {
                getUser = GetUser
            };
            frmCheckActiveFromArtist.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmHistoryBookingTatoo frmHistoryBookingTatoo = new frmHistoryBookingTatoo()
            {
                user = GetUser
            };
            frmHistoryBookingTatoo.Show();
        }
    }
}
