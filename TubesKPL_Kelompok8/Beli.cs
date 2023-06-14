using System.Diagnostics.SymbolStore;

namespace TubesKPL_Kelompok8
{
    public partial class Beli : Form
    {
        public Beli()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pembayaran next1 = new Pembayaran();
            next1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Mendapatkan nilai input dari TextBox1
            if (int.TryParse(textBox1.Text, out int jumlah))
            {
                // Mengalikan jumlah dengan nilai awal label7 (20000)
                int hasil = jumlah * 20000;

                // Menampilkan hasil pada label7 dan label17
                label7.Text = hasil.ToString();
                label17.Text = hasil.ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Mendapatkan nilai input dari TextBox3
            if (int.TryParse(textBox3.Text, out int jumlahHari))
            {
                // Menampilkan hasil jumlah hari pada label13 dan label20
                label13.Text = jumlahHari.ToString();
                label20.Text = jumlahHari.ToString();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Menampilkan deskripsi
            string inputText = textBox2.Text;
            label22.Text = inputText;
        }

        private void label22_Click(object sender, EventArgs e)
        {
            
        }
    }
}