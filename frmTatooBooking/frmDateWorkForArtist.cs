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
    public partial class frmDateWorkForArtist : Form
    {
        public static IDateWorkForArtistRepository dateWorkForArtistRepository = new DateWorkForArtistRepository();
        public Artist GetArtist { get; set; }
        public DateWorkForArtist DateWorkForArtist { get; set; }
        public bool InsertOrUpdate { get; set; }
        public frmDateWorkForArtist()
        {
            InitializeComponent();
        }

        private void frmDateWorkForArtist_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH"; // Only use hours and minutes
            dateTimePicker2.ShowUpDown = true;

            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "HH"; // Only use hours and minutes
            dateTimePicker3.ShowUpDown = true;
            if (InsertOrUpdate == false)
            {

            }
            else
            {
                textBox1.Text = DateWorkForArtist.Id.ToString();
                dateTimePicker1.Value = DateWorkForArtist.WorkDate.Value;
                dateTimePicker2.Value = DateTime.Parse(DateWorkForArtist.StartWorkHour.ToString());
                dateTimePicker3.Value = DateTime.Parse(DateWorkForArtist.EndWorkHour.ToString());
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                if (dateTimePicker2.Value.TimeOfDay.Hours > dateTimePicker3.Value.TimeOfDay.Hours)
                {
                    MessageBox.Show("Time start is great than time end");
                    return;
                }
                if (DateTime.Compare(DateTime.Now.Date, dateTimePicker1.Value.Date) > 0)
                {

                    MessageBox.Show("You choose incorrect date to work");
                    return;
                }

                var dateWorkForArtist = new DateWorkForArtist();
                dateWorkForArtist.Id = int.Parse(textBox1.Text);
                dateWorkForArtist.WorkDate = dateTimePicker1.Value;
                dateWorkForArtist.StartWorkHour = dateTimePicker2.Value.TimeOfDay;
                dateWorkForArtist.EndWorkHour = dateTimePicker3.Value.TimeOfDay;
                dateWorkForArtist.ArtistId = (int)GetArtist.Id;
                dateWorkForArtistRepository.UpdateDateWorkForArtist(dateWorkForArtist);


            }
            else
            {
                if (dateTimePicker2.Value.TimeOfDay.Hours > dateTimePicker3.Value.TimeOfDay.Hours)
                {
                    MessageBox.Show("Time start is great than time end");
                    return;
                }
                if (DateTime.Compare(DateTime.Now.Date, dateTimePicker1.Value.Date) > 0)
                {

                    MessageBox.Show("You choose incorrect date to work");
                    return;
                }
                DateWorkForArtist dateWorkForArtist = new DateWorkForArtist();
                dateWorkForArtist.ArtistId = (int)GetArtist.Id;
                dateWorkForArtist.WorkDate = dateTimePicker1.Value;
                dateWorkForArtist.StartWorkHour = dateTimePicker2.Value.TimeOfDay;
                dateWorkForArtist.EndWorkHour = dateTimePicker3.Value.TimeOfDay;
                dateWorkForArtistRepository.AddDateWorkForArtist(dateWorkForArtist);
            }
        }
    }
}
