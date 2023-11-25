using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TatooBookingLibrary.Models;
using TatooBookingLibrary.Repository;

namespace frmTatooBooking
{
    public partial class frmArtistManagememt : Form
    {
        IArtistRepository artistRepository = new ArtistRepository();
        IStudioRepository studioRepository = new StudioRepository();
        private List<Studio> studios;
        public int studioID { get; set; }

        public frmArtistManagememt(int studioID)
        {
            InitializeComponent();
            this.studioID = studioID;
            studios = studioRepository.GetAllStudios();
            foreach (Studio studio in studios)
            {
                cbbStudio.Items.Add(studio.Name);
            }
        }

        //------------------------
        //Tải dữ liệu từ DB
        private void btnView_Click(object sender, EventArgs e)
        {
            LoadArtistList();
        }

        private void LoadArtistList()
        {
            List<Artist> list = artistRepository.GetAllArtistsByStudioID(studioID);
            dgvArtistList.Rows.Clear();
            dgvArtistList.Refresh();
            foreach (var tempArtist in list)
            {
                dgvArtistList.Rows.Add(
                    tempArtist.Id,
                    tempArtist.Name,
                    tempArtist.Email,
                    tempArtist.Password,
                    tempArtist.StudioId,
                    tempArtist.Studio.Name,
                    tempArtist.Degree,
                    tempArtist.Phone,
                    tempArtist.Address);
            }
        }

        //------------------------
        //Xóa dữ liệu khỏi DB
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure you wanna delete?",
                                "Artist Management - Deleting Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            foreach (DataGridViewRow row in dgvArtistList.SelectedRows)
            {
                Artist artist = new Artist();
                artist.Id = int.Parse(row.Cells["ID"].Value.ToString());
                artistRepository.DeleteArtist(artist);
            }
            LoadArtistList();
        }

        //------------------------
        //Lưu dữ liệu vào DB
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure you wanna save?",
                                "Artist Management - Saving Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            try
            {
                Artist artist = GetArtistObject();
                artist.Id = null;
                artistRepository.SaveArtist(artist);
            }
            catch (Exception ex)
            {
                d = MessageBox.Show("Something went wrong",
                                "Artist Management - Saving Record", MessageBoxButtons.OK, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            }
            LoadArtistList();
        }

        //----------------------------------------
        //Lấy data từ textbox và combobox
        private Artist GetArtistObject()
        {
            Studio studio = null;

            //Lấy dữ liệu từ textbox
            var name = txtName.Text;
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            var studioName = cbbStudio.Text;
            var degree = txtDegree.Text;
            var phone = txtPhone.Text;
            var address = txtAddress.Text;

            //Lưu trữ Studio từ ComboBox
            foreach (Studio s in studios)
            {
                if (s.Name == studioName)
                {
                    studio = s;
                }
            }

            //Đưa các biến vào trong object
            Artist artist = new Artist();
            try
            {
                artist = new Artist
                {
                    Name = name,
                    Email = email,
                    Password = password,
                    StudioId = studio.Id,
                    Degree = degree,
                    Phone = phone,
                    Address = address,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get artist");
            }
            return artist;
        }

        //----------------------------------------
        //Update record lên DB
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure you wanna update?",
                                "Artist Management - Saving Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            try
            {
                Artist artist = new Artist();
                artist = GetArtistObject();
                artist.Id = int.Parse(txtID.Text);
                artistRepository.UpdateArtist(artist);
            }
            catch (Exception ex)
            {
                d = MessageBox.Show("Something went wrong",
                                "Artist Management - Updating Record", MessageBoxButtons.OK, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            }
            LoadArtistList();
        }

        //----------------------------------------
        //Đưa thông tin từ selected cell lên textbox
        private void dgvArtistList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgvArtistList.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtEmail.Text = row.Cells[2].Value.ToString();
                txtPassword.Text = row.Cells[3].Value.ToString();
                cbbStudio.Text = row.Cells[5].Value.ToString();
                txtDegree.Text = row.Cells[6].Value.ToString();
                txtPhone.Text = row.Cells[7].Value.ToString();
                txtAddress.Text = row.Cells[8].Value.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
            {
                LoadArtistList();
            }
            else if (txtSearch.Text.Length >= 1)
            {
                string findName = txtSearch.Text;
                List<Artist> listArtist = artistRepository.GetArtistByName(findName);
                dgvArtistList.Rows.Clear();
                dgvArtistList.Refresh();
                foreach (var tempArtist in listArtist)
                {
                    dgvArtistList.Rows.Add(
                        tempArtist.Id,
                        tempArtist.Name,
                        tempArtist.Email,
                        tempArtist.Password,
                        tempArtist.StudioId,
                        tempArtist.Studio.Name,
                        tempArtist.Degree,
                        tempArtist.Phone,
                        tempArtist.Address);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
