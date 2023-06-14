using Revif;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TubesKPL_Kelompok8
{
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            LoginConvig loginConvig = new LoginConvig();
            loginConvig.ReadKonfigFile();

            if (string.IsNullOrEmpty(newUsernameTextBox.Text) && string.IsNullOrEmpty(newPasswordTextBox.Text))
            {
                this.Hide();
            }
            else
            {
                bool passwordMatched = false;

                for (int i = 0; i < loginConvig.ListAkun.akun.Count; i++)
                {
                    if (loginConvig.ListAkun.akun[i].password == currentPasswordTextBox.Text)
                    {
                        if (!string.IsNullOrEmpty(newUsernameTextBox.Text) && newUsernameTextBox.Text != loginConvig.ListAkun.akun[i].username)
                        {
                            Debug.Assert(newUsernameTextBox.Text.Length <= 15, "Username tidak boleh melebihi 15 karakter atau kosong");
                            loginConvig.ListAkun.akun[i].username = newUsernameTextBox.Text;
                        }

                        if (!string.IsNullOrEmpty(newPasswordTextBox.Text) && newPasswordTextBox.Text == confirmPasswordTextBox.Text)
                        {
                            loginConvig.ListAkun.akun[i].password = newPasswordTextBox.Text;
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show(this, "Password tidak sesuai", "Konfirmasi", MessageBoxButtons.OK);
                            return;
                        }

                        passwordMatched = true;
                        break;
                    }
                }

                if (!passwordMatched)
                {
                    DialogResult result = MessageBox.Show(this, "Isi password sebelumnya untuk melakukan save", "Konfirmasi", MessageBoxButtons.OK);
                    return;
                }
            }

            loginConvig.WriteKonfigFile();
            this.Hide();
            Application.Exit();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            string link = "https://img.freepik.com/free-icon/black-male-user-symbol_318-60703.jpg";
            //pictureBox1.ImageLocation = link;

            WebClient webClient = new WebClient();
            byte[] imageData = webClient.DownloadData(link);

            // Membaca gambar sebagai objek Image
            Image image;
            using (var ms = new System.IO.MemoryStream(imageData))
            {
                image = Image.FromStream(ms);
            }

            // Mengatur gambar ke Picture Box dengan perbandingan yang benar
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = image;

            //int newSize = 105;
            //pictureBox1.Size = new Size(newSize, newSize);
        }

        private void EditProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
