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
    public partial class frmBillFroCustomer : Form
    {
        public static IBookingServiceRepository bookingServiceRepository = new BookingServiceRepository();
        public static IUserRepository userRepository = new UserRepository();
        public static ITatooRepository tatooRepository = new TatooRepository();
        public Artist artist { get; set; }
        public frmBillFroCustomer()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dateTimePicker2.Visible = true;
                dateTimePicker2.Value = DateTime.Now;

            }
            else
            {
                dateTimePicker2.Visible = false;
                dateTimePicker2.Value = DateTime.Parse("03/11/1800 4:34 CH");
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                dateTimePicker3.Visible = true;
                dateTimePicker3.Value = DateTime.Now;
            }
            else
            {
                dateTimePicker3.Visible = false;
                dateTimePicker3.Value = DateTime.Parse("03/11/1800 4:34 CH");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                var bookingService = bookingServiceRepository.GetBookingServices().SingleOrDefault(x => x.Id == id);
                DateTime dateTime = DateTime.Now;
                if (DateTime.Compare(dateTimePicker1.Value, dateTime) < 0)
                {
                    MessageBox.Show("Day 1 is not valid");
                    return;
                }
                if (dateTimePicker2.Value.Year == 1800)
                {
                    bookingService.InkDay2 = null;
                }
                if (dateTimePicker2.Value.Year != 1800)
                {
                    if (DateTime.Compare(dateTimePicker2.Value, dateTime) < 0)
                    {
                        MessageBox.Show("Day 2 is not valid");
                        return;
                    }
                    else
                    {
                        if (DateTime.Compare(dateTimePicker2.Value, dateTimePicker1.Value) < 0)
                        {
                            MessageBox.Show("Day 1 greater than Day 2");
                            return;
                        }
                        else
                        {
                            bookingService.InkDay2 = dateTimePicker2.Value;
                        }
                    }
                }
                if (dateTimePicker3.Value.Year == 1800)
                {
                    bookingService.InkDay3 = null;
                }
                if (dateTimePicker3.Value.Year != 1800)
                {
                    if (DateTime.Compare(dateTimePicker3.Value, dateTime) < 0)
                    {
                        MessageBox.Show("Day 3 is not valid");
                        return;
                    }
                    else
                    {
                        if (DateTime.Compare(dateTimePicker3.Value, dateTimePicker1.Value) < 0)
                        {
                            MessageBox.Show("Day 1 greater than Day 3");
                            return;
                        }
                        else if (dateTimePicker2.Value.Year != 1800)
                        {
                            if (DateTime.Compare(dateTimePicker3.Value, dateTimePicker2.Value) < 0)
                            {
                                MessageBox.Show("Day 2 greater than Day 3");
                                return;
                            }
                        }

                        bookingService.InkDay3 = dateTimePicker3.Value;
                    }
                }
                bookingService.InkDay1 = dateTimePicker1.Value;
                bookingService.Status = 1;
                bookingService.TotalPrice = decimal.Parse(textBox2.Text);
                bookingServiceRepository.UpdateBookingService(bookingService);
                LoadData();
                this.Close();


            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void frmBillFroCustomer_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label1.Visible = false;
            LoadData();
        }

        public void LoadData()
        {
            button1.Enabled = false;
            dataGridView1.Rows.Clear();
            var books = bookingServiceRepository.GetBookingServices().Where(x => x.ArtistId == artist.Id && x.Status == 0);
            foreach (BookingService book in books)
            {
                book.Users = userRepository.GetUsers().SingleOrDefault(x => x.Id == book.UsersId);
                book.Tatoo = tatooRepository.GetTatoos().SingleOrDefault(x => x.Id == book.TatooId);
                dataGridView1.Rows.Add(book.Id, book.Users.Name, artist.Name, book.Tatoo.TatooName, book.TotalPrice, book.Status);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
            }
            button1.Enabled = true;
        }



    }
}
