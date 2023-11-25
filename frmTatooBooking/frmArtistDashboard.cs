using frmTatooBooking.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TatooBookingLibrary.Models;
using TatooBookingLibrary.Repository;

namespace frmTatooBooking
{
    public partial class frmArtistDashboard : Form
    {
        public static IDateWorkForArtistRepository dateWorkForArtistRepository = new DateWorkForArtistRepository();
        public static IArtistRepository artistRepository = new ArtistRepository();
        public static IBookingTatooRepository bookingTatooRepository = new BookingTatooRepository();
        public static IUserRepository userRepository = new UserRepository();
        public Artist getArtist { get; set; }
        public frmArtistDashboard()
        {
            InitializeComponent();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            frmUpdateProfieArtist frmUpdateProfieArtist = new frmUpdateProfieArtist()
            {
                GetArtist = getArtist
            };
            if (frmUpdateProfieArtist.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                LoadDataAboutRequestCustomer();
            }
        }

        private void btnCreateDateWork_Click(object sender, EventArgs e)
        {
            frmDateWorkForArtist frmDateWorkForArtist = new frmDateWorkForArtist()
            {
                Text = "Create Work For Artist",
                GetArtist = getArtist,
                InsertOrUpdate = false
            };
            if (frmDateWorkForArtist.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                LoadDataAboutRequestCustomer();
            }
        }

        private void frmArtistDashboard_Load(object sender, EventArgs e)
        {

            LoadData();
            LoadDataAboutRequestCustomer();
        }

        public void LoadData()
        {
            btnDeleteDate.Enabled = false;
            btnUpdateDate.Enabled = false;
            label1.Visible = false;
            textBox1.Visible = false;
            dgvDateWork.Rows.Clear();
            var list = dateWorkForArtistRepository.GetDateWorkForArtists().Where(x => x.ArtistId == getArtist.Id);
            foreach (DateWorkForArtist date in list)
            {
                date.Artist = artistRepository.GetArtist((int)date.ArtistId);
                string startTime = date.StartWorkHour.Value.Hours.ToString();
                string endTime = date.EndWorkHour.Value.Hours.ToString();

                dgvDateWork.Rows.Add(date.Id, date.Artist.Name, date.WorkDate.Value.ToString("dd/MM/yyyy"), startTime, endTime);
            }
        }
        public void LoadDataAboutRequestCustomer()
        {
            btnAgree.Enabled = false;
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            textBox3.Visible = false;
            dataGridView1.Rows.Clear();
            var list = bookingTatooRepository.GetBookingTatoos().Where(x => x.ArtistId == getArtist.Id && x.Status == 0);
            foreach (BookingTatoo tatoo in list)
            {

                tatoo.Artist = artistRepository.GetArtist((int)tatoo.ArtistId);
                tatoo.Users = userRepository.GetUsers().SingleOrDefault(x => x.Id == tatoo.UsersId);
                dataGridView1.Rows.Add(tatoo.Id, tatoo.Users.Name, tatoo.Artist.Name, tatoo.DateCreate.Value.ToString("dd-MM-yyyy"), tatoo.UsersPhone, tatoo.UsersBookDate.Value.ToString("dd-MM-yyyy"), tatoo.UsersBookTime.Value.Hours, tatoo.Status);
            }
        }

        private void dgvDateWork_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = dgvDateWork.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
            }
            btnUpdateDate.Enabled = true;
            btnDeleteDate.Enabled = true;
        }

        private void btnUpdateDate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            var date = dateWorkForArtistRepository.GetDateWorkForArtists().SingleOrDefault(x => x.Id == id);
            if (date == null)
            {
                MessageBox.Show("Error");
                return;
            }
            frmDateWorkForArtist frmDateWorkForArtist = new frmDateWorkForArtist()
            {
                Text = "Update Date",
                DateWorkForArtist = date,
                GetArtist = getArtist,
                InsertOrUpdate = true
            };
            if (frmDateWorkForArtist.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                LoadDataAboutRequestCustomer();
            }

        }

        private void btnDeleteDate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            dateWorkForArtistRepository.DeleteDateWorkForArtist(id);
            MessageBox.Show("Deleted!");
            LoadData();
            LoadDataAboutRequestCustomer();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Column6"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["Column13"].Value.ToString();
            }
            btnAgree.Enabled = true;
        }

        private void btnAgree_Click(object sender, EventArgs e)
        {
            int id = int.Parse((string)textBox2.Text);
            byte status = byte.Parse(textBox3.Text);
            var bookingtattoo = bookingTatooRepository.GetBookingTatoos().SingleOrDefault(x => x.Id == id);
            bookingtattoo.Status = 1;
            bookingTatooRepository.UpdateBookingTatoo(bookingtattoo);
            MessageBox.Show("You are actived from booking customer");
            LoadData();
            LoadDataAboutRequestCustomer();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            frmBillFroCustomer frmBillFroCustomer = new frmBillFroCustomer()
            {
                artist = getArtist
            };
            frmBillFroCustomer.Show();


        }
    }
}
