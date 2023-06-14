using System.Diagnostics;
using System.Diagnostics.SymbolStore;

namespace TubesKPL_Kelompok8
{
    public partial class Beli : Form
    {
        public string judul { get; set; }
        public string deskripsi { get; set; }
        public int durasi { get; set; }
        public int harga { get; set; }
        public string status { get; set; }
        public Beli()
        {
            InitializeComponent();
            this.judul = judul;
            this.deskripsi = deskripsi;
            this.durasi = durasi;
            this.harga = harga;
            this.status = status;
        }

        private void Beli_Load(object sender, EventArgs e)
        {
            label3.Text = "Jasa Editor Video";
            judul = label3.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Harap lengkapi semua data sebelum melanjutkan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Tidak melanjutkan jika ada field yang kosong
            }

            Pembayaran BukaPembayaran = new Pembayaran();
            BukaPembayaran.SetHalamanSebelumnya(this); // Menetapkan halaman sebelumnya ke form saat ini
            BukaPembayaran.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Mendapatkan nilai input dari TextBox1
            if (int.TryParse(textBox1.Text, out int inputHarga))
            {
                // Mengalikan jumlah dengan nilai awal harga (20000)
                harga = inputHarga * 20000;

                // Menampilkan hasil pada label7 dan label17
                label7.Text = harga.ToString();
                label17.Text = harga.ToString();
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
                durasi = jumlahHari;
                label13.Text = durasi.ToString();
                label20.Text = durasi.ToString();
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
            deskripsi = textBox2.Text;
            label22.Text = deskripsi;
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}