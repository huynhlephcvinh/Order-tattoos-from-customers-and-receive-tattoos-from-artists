using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TatooBookingLibrary.Models;
using TatooBookingLibrary.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Imaging;

namespace frmTatooBooking
{
    public partial class frmTatooForStaff : Form
    {
        public static ITatooRepository tatooRepository = new TatooRepository();
        public static ITatooCategoryRepository tatooCategoryRepository = new TatooCategoryRepository();
        public frmTatooForStaff()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
                richTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
                comboBox1.SelectedIndex = comboBox1.FindStringExact(dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value.ToString());
                byte check = byte.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column7"].Value.ToString());
                if (check == 1)
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                byte[] imgData = (byte[])dataGridView1.Rows[e.RowIndex].Cells["Column6"].Value;
                MemoryStream ms = new MemoryStream(imgData);
                pictureBox1.Image = Image.FromStream(ms);


            }
            btnUpdate.Enabled = true;
        }

        private void frmTatooForStaff_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            LoadData();
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = tatooCategoryRepository.GetTatooCategories();

        }

        public void LoadData()
        {
            btnUpdate.Enabled = false;
            dataGridView1.Rows.Clear();
            List<Tatoo> tatoos = tatooRepository.GetTatoos();
            foreach (Tatoo tatoo in tatoos)
            {
                tatoo.Category = tatooCategoryRepository.GetTatooCategory((int)tatoo.CategoryId);
                dataGridView1.Rows.Add(tatoo.Id, tatoo.TatooName, tatoo.TatooDescription, tatoo.Category.CategoryName, tatoo.Price, tatoo.Img, tatoo.Status);
            }
        }

        public void LoadForm()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            richTextBox1.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateTatooStaff frmAddOrUpdateTatooStaff = new frmAddOrUpdateTatooStaff();
            if (frmAddOrUpdateTatooStaff.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                LoadForm();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File(*.jpe; *.jpeg; *.bmp) | *.jpg;*.jpeg; *.bmp";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        string FileName = openFileDialog.FileName;
                        textBox4.Text = FileName;
                        if (myStream.Length > 512000)
                        {
                            MessageBox.Show("File Size limit exceeded");
                        }
                        else
                        {
                            pictureBox1.Load(FileName);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                Tatoo tatoo = new Tatoo();
                tatoo.Id = int.Parse(textBox1.Text);
                tatoo.TatooName = textBox2.Text;
                tatoo.TatooDescription = richTextBox1.Text;
                tatoo.CategoryId = int.Parse(comboBox1.SelectedValue.ToString());
                tatoo.Price = decimal.Parse(textBox3.Text);
                if (radioButton1.Checked == true)
                {
                    tatoo.Status = 1;
                }
                else
                {
                    tatoo.Status = 0;
                }
                MemoryStream stream = new MemoryStream();
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stream.ToArray();
                tatoo.Img = pic;
                tatooRepository.UpdateTatoo(tatoo);
                MessageBox.Show("Ban da update thanh cong");
                LoadData();
                LoadForm();
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                tatooRepository.DeleteTatoo(id);
                MessageBox.Show("Deleted!");
                LoadData();
                LoadForm();
            }
            catch { }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
