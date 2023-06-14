using Revif;

namespace TubesKPL_Kelompok8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginConvig loginConvig = new LoginConvig();
            loginConvig.ReadKonfigFile();
            int i;
            for (i = 0; i < loginConvig.ListAkun.akun.Count; i++)
            {
                if (loginConvig.ListAkun.akun[i].username == usernameTextBox.Text && loginConvig.ListAkun.akun[i].password == passwordTextBox.Text)
                {
                    EditProfile editProfile = new EditProfile();
                    editProfile.Show();
                    this.Hide();
                    break;
                }
                else
                {
                    DialogResult result = MessageBox.Show(this, "Password tidak sesuai", "Wrong password", MessageBoxButtons.OK);
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}