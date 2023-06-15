using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TubesKPL_Kelompok8
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginConvig loginConvig = new LoginConvig();
            loginConvig.ReadKonfigFile();
            int i;
            bool found = false;
            for (i = 0; i < loginConvig.ListAkun.akun.Count; i++)
            {
                if (loginConvig.ListAkun.akun[i].username == usernameTextBox.Text && VerifyPassword(passwordTextBox.Text) == VerifyPassword(loginConvig.ListAkun.akun[i].password))
                {
                    SendText();
                    Form3.GetInstance(usernameTextBox.Text).Show();
                    this.Hide();
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                DialogResult result = MessageBox.Show(this, "Password tidak sesuai", "Wrong password", MessageBoxButtons.OK);
            }
        }

        private string VerifyPassword(string inputPassword)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputPassword));
            string hashedInputPassword = Convert.ToBase64String(hashBytes);
            return hashedInputPassword;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Register form4 = new Register();
            form4.Show();
            this.Hide();
        }

        public event Action<string> TextSent;
        private void SendText()
        {
            // Mengirimkan teks dari TextBox melalui event
            TextSent?.Invoke(usernameTextBox.Text);
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
