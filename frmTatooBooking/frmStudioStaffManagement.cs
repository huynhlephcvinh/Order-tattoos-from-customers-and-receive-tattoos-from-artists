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
    public partial class frmStudioStaffManagement : Form
    {
        StudioStaffRepository studioStaffRepository = new StudioStaffRepository();
        IStudioRepository studioRepository = new StudioRepository();
        private List<Studio> studios;

        public frmStudioStaffManagement()
        {
            InitializeComponent();
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
            LoadStudioStaffList();
        }

        private void LoadStudioStaffList()
        {
            List<StudioStaff> list = studioStaffRepository.GetAllStudioStaffs();
            dgvStudioStaffList.Rows.Clear();
            dgvStudioStaffList.Refresh();
            foreach (var tempStudioStaff in list)
            {
                string statuss = "True";
                if (tempStudioStaff.Status == 1)
                {
                    statuss = "True";
                }
                else if (tempStudioStaff.Status == 0)
                {
                    statuss = "False";

                }
                dgvStudioStaffList.Rows.Add(
                    tempStudioStaff.Id,
                    tempStudioStaff.Name,
                    tempStudioStaff.Email,
                    tempStudioStaff.Password,
                    tempStudioStaff.StudioId,
                    tempStudioStaff.Studio.Name,
                    statuss);
            }
        }

        //------------------------
        //Xóa dữ liệu khỏi DB
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure you wanna delete?",
                                "StudioStaff Management - Deleting Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            foreach (DataGridViewRow row in dgvStudioStaffList.SelectedRows)
            {
                StudioStaff studioStaff = new StudioStaff();
                studioStaff.Id = int.Parse(row.Cells["ID"].Value.ToString());
                studioStaffRepository.Delete(studioStaff);
            }
            LoadStudioStaffList();
        }

        //------------------------
        //Lưu dữ liệu vào DB
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure you wanna save?",
                                "StudioStaff Management - Saving Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            try
            {
                StudioStaff studioStaff = GetStudioStaffObject();
                studioStaff.Id = null;
                studioStaffRepository.SaveStudioStaff(studioStaff);
            }
            catch (Exception ex)
            {
                d = MessageBox.Show("Something went wrong",
                                "StudioStaff Management - Saving Record", MessageBoxButtons.OK, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            }
            LoadStudioStaffList();
        }

        //----------------------------------------
        //Lấy data từ textbox và combobox
        private StudioStaff GetStudioStaffObject()
        {
            Studio studio = null;

            //Lấy dữ liệu từ textbox
            var name = txtName.Text;
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            var studioName = cbbStudio.Text;
            var tempStatus = cbbStatus.Text;

            byte status;

            //Lưu trữ Studio từ ComboBox
            foreach (Studio s in studios)
            {
                if (s.Name == studioName)
                {
                    studio = s;
                }
            }

            //Đưa các biến vào trong object
            StudioStaff studioStaff = new StudioStaff();
            try
            {
                studioStaff = new StudioStaff
                {
                    Name = name,
                    Email = email,
                    Password = password,
                    StudioId = studio.Id,
                    Status = byte.Parse(tempStatus)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get studioStaff");
            }
            return studioStaff;
        }

        //----------------------------------------
        //Update record lên DB
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure you wanna update?",
                                "StudioStaff Management - Saving Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            try
            {
                StudioStaff studioStaff = new StudioStaff();
                studioStaff = GetStudioStaffObject();
                studioStaff.Id = int.Parse(txtID.Text);
                studioStaffRepository.Update(studioStaff);
            }
            catch (Exception ex)
            {
                d = MessageBox.Show("Something went wrong",
                                "StudioStaff Management - Updating Record", MessageBoxButtons.OK, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            }
            LoadStudioStaffList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
            {
                LoadStudioStaffList();
            }
            else if (txtSearch.Text.Length >= 1)
            {
                string findName = txtSearch.Text;
                List<StudioStaff> list = studioStaffRepository.GetStafftByName(findName);
                dgvStudioStaffList.Rows.Clear();
                dgvStudioStaffList.Refresh();
                foreach (var tempStudioStaff in list)
                {
                    string statuss = "True";
                    if (tempStudioStaff.Status == 1)
                    {
                        statuss = "True";
                    }
                    else if (tempStudioStaff.Status == 0)
                    {
                        statuss = "False";

                    }
                    dgvStudioStaffList.Rows.Add(
                        tempStudioStaff.Id,
                        tempStudioStaff.Name,
                        tempStudioStaff.Email,
                        tempStudioStaff.Password,
                        tempStudioStaff.StudioId,
                        tempStudioStaff.Studio.Name,
                        statuss);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBillForAdmin frmBillForAdmin = new frmBillForAdmin();
            frmBillForAdmin.Show();
        }
    }
}
