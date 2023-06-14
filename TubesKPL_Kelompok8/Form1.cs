namespace TubesKPL_Kelompok8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Apakah anda yakin? ", "Konfimasi", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                UnggahJasaConfig config = new UnggahJasaConfig();
                config.tambahData("Admin", textBoxServiceName.Text, int.Parse(textBoxPrice.Text), richTextBox1.Text);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}