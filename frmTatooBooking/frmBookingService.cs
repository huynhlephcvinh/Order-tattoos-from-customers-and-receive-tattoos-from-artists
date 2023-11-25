using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TatooBookingLibrary.Models;
using TatooBookingLibrary.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frmTatooBooking
{
    public partial class frmBookingService : Form
    {
        public Artist artist { get; set; }
        public User user { get; set; }
        public BookingTatoo bookingTatoo { get; set; }
        public static ITatooCategoryRepository categoryRepository = new TatooCategoryRepository();
        public static ITatooRepository tatooRepository = new TatooRepository();
        public static IBookingServiceRepository bookingServiceRepository = new BookingServiceRepository();
        public static IStudioRepository sudioRepository = new StudioRepository();
        public static IBookingTatooRepository bookingTatooRepository = new BookingTatooRepository();
        public frmBookingService()
        {
            InitializeComponent();
        }

        private void frmBookingService_Load(object sender, EventArgs e)
        {

            label7.Visible = false;
            textBox2.Visible = false;
            label6.Text = "Artist of yours is " + artist.Name;
            LoadData();

        }
        public void LoadData()
        {
            button1.Enabled = false;
            dataGridView1.Rows.Clear();
            List<Tatoo> tatoos = tatooRepository.GetTatoos();
            foreach (Tatoo tatoo in tatoos)
            {
                tatoo.Category = categoryRepository.GetTatooCategory((int)tatoo.CategoryId);
                dataGridView1.Rows.Add(tatoo.Id, tatoo.TatooName, tatoo.TatooDescription, tatoo.Category.CategoryName, tatoo.Price, tatoo.Img, tatoo.Status);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
            }
            button1.Enabled = true;
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BookingService bookingService = new BookingService();

                bookingService.UsersId = user.Id;
                bookingService.ArtistId = artist.Id;
                bookingService.TatooId = int.Parse(textBox2.Text);

                bookingService.TotalPrice = decimal.Parse(textBox1.Text);
                bookingService.Status = 0;

                bookingServiceRepository.CreateBookingService(bookingService);
                bookingTatoo.Status = 2;
                bookingTatooRepository.UpdateBookingTatoo(bookingTatoo);


                artist.Studio = sudioRepository.GetStudio(artist.Id);
                MessageBox.Show("Order successed! Go to Studio: " + artist.Studio.Name + " to Artis: " + artist.Name + " tattoo for you");
                this.Close();

            }
            catch
            {
                MessageBox.Show("Error!!!!!!");
            }
        }


    }
}
