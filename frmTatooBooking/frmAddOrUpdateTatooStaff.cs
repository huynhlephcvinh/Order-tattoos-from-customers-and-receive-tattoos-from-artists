using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TatooBookingLibrary.Repository;
using TatooBookingLibrary.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frmTatooBooking
{
    public partial class frmAddOrUpdateTatooStaff : Form
    {
        public static ITatooRepository tatooRepository = new TatooRepository();
        public static ITatooCategoryRepository tatooCategoryRepository = new TatooCategoryRepository();
        public frmAddOrUpdateTatooStaff()
        {
            InitializeComponent();
        }

        private void frmAddOrUpdateTatooStaff_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = tatooCategoryRepository.GetTatooCategories();
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

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox2.Text.Equals(""))
                {
                    MessageBox.Show("Name is empty");
                    return;
                }
                if (richTextBox1.Text.Equals(""))
                {
                    MessageBox.Show("Description is empty");
                    return;
                }
                if (textBox3.Text.Equals(""))
                {
                    MessageBox.Show("Price is empty");
                    return;
                }
                MemoryStream stream = new MemoryStream();
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                Tatoo tatoo = new Tatoo();
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
                byte[] pic = stream.ToArray();
                tatoo.Img = pic;
                tatooRepository.CreateTatoo(tatoo);

            }
            catch
            {
                MessageBox.Show("Erorr!");
            }


        }
    }
}
