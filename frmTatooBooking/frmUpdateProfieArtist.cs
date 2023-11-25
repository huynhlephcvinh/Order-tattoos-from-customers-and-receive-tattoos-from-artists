using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TatooBookingLibrary.Models;
using TatooBookingLibrary.Repository;

namespace frmTatooBooking
{
    public partial class frmUpdateProfieArtist : Form
    {
        public static IArtistRepository artistRepository = new ArtistRepository();
        public Artist GetArtist { get; set; }
        public frmUpdateProfieArtist()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox6.PasswordChar = '\0';

            }
            else
            {
                textBox6.PasswordChar = '*';
            }

        }

        private void frmUpdateProfieArtist_Load(object sender, EventArgs e)
        {
            textBox1.Text = GetArtist.Name.ToString();
            textBox2.Text = GetArtist.Email.ToString();
            textBox3.Text = GetArtist.Degree.ToString();
            textBox4.Text = GetArtist.Phone.ToString();
            textBox5.Text = GetArtist.Address.ToString();
            textBox6.Text = GetArtist.Password.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                Regex regex = new Regex(@"^\d$");
                if (regex.IsMatch(textBox4.Text))
                {
                    MessageBox.Show("Phone is digit");
                    return;
                }
                if (textBox1.Text.Equals(""))
                {
                    MessageBox.Show("Name is empty");
                    return;
                }
                if (textBox2.Text.Equals(""))
                {
                    MessageBox.Show("Email is empty");
                    return;
                }
                if (textBox3.Text.Equals(""))
                {
                    MessageBox.Show("Degree is empty");
                    return;
                }
                if (textBox4.Text.Equals(""))
                {
                    MessageBox.Show("Phone is empty");
                    return;
                }
                if (textBox5.Text.Equals(""))
                {
                    MessageBox.Show("Address is empty");
                    return;
                }
                if (textBox6.Text.Equals(""))
                {
                    MessageBox.Show("Password is empty");
                    return;
                }
                Artist artist = GetArtist;
                artist.Name = textBox1.Text;
                artist.Email = textBox2.Text;
                artist.Degree = textBox3.Text;
                artist.Phone = textBox4.Text;
                artist.Address = textBox5.Text;
                artist.Password = textBox6.Text;
                artistRepository.UpdateArtist(artist);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
