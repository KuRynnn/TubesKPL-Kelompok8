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
    public sealed partial class EditProfile : Form
    {
        private string receivedText;
        private static EditProfile _instance;
        private EditProfile(string textFromForm3)
        {
            InitializeComponent();
            receivedText = textFromForm3;
        }

        public static Form GetInstance(string recievedText)
        {
            if (_instance == null)
            {
                _instance = new EditProfile(recievedText);
            }
            return _instance;
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            LoginConvig loginConvig = new LoginConvig();
            loginConvig.ReadKonfigFile();

            if (string.IsNullOrEmpty(newUsernameTextBox.Text) || string.IsNullOrEmpty(newPasswordTextBox.Text) ||
                    string.IsNullOrEmpty(confirmPasswordTextBox.Text) || string.IsNullOrEmpty(currentPasswordTextBox.Text))
            {
                DialogResult result = MessageBox.Show(this, "Seluruh field harus diisi", "Konfirmasi", MessageBoxButtons.OK);
            }
            else
            {
                int index = -1;
                for (int i = 0; i < loginConvig.ListAkun.akun.Count; i++)
                {
                    if (loginConvig.ListAkun.akun[i].username == receivedText)
                    {
                        index = i; break;
                    }
                }

                if (loginConvig.ListAkun.akun[index].password == currentPasswordTextBox.Text)
                {
                    if(newPasswordTextBox.Text == confirmPasswordTextBox.Text)
                    {
                        loginConvig.ListAkun.akun[index].password = newPasswordTextBox.Text;
                        loginConvig.ListAkun.akun[index].username = newUsernameTextBox.Text;
                        receivedText = newUsernameTextBox.Text;
                        DialogResult result = MessageBox.Show(this, "Username dan Password telah terganti", "Konfirmasi", MessageBoxButtons.OK);
                        Form3.GetInstance(receivedText).Show();
                        
                        this.Hide();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show(this, "Konfirmasi Password tidak sesuai", "Konfirmasi", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show(this, "Current Password salah", "Konfirmasi", MessageBoxButtons.OK);
                }
            }
            loginConvig.WriteKonfigFile();
        }

        private void EditProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form3.GetInstance(receivedText).Show();
            this.Hide();
        }
    }
}
