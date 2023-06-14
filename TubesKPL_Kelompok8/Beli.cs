using System.Diagnostics;
using System.Diagnostics.SymbolStore;

namespace TubesKPL_Kelompok8
{
    public partial class Beli : Form
    {
        public enum StatusPesanan
        {
            BelumBayar,
            MenungguPembayaran,
            SedangDiProses,
            Selesai,
            Dibatalkan
        }

        private Dictionary<StatusPesanan, string> statusMapping = new Dictionary<StatusPesanan, string>()
        {
            { StatusPesanan.BelumBayar, "Belum Bayar" },
            { StatusPesanan.MenungguPembayaran, "Menunggu Pembayaran" },
            { StatusPesanan.SedangDiProses, "Sedang Di Proses" },
            { StatusPesanan.Selesai, "Selesai" },
            { StatusPesanan.Dibatalkan, "Dibatalkan" }
        };

        public StatusPesanan Status { get; set; }
        public string StatusText => statusMapping[Status];

        public string Judul { get; set; }
        public string Deskripsi { get; set; }
        public int Durasi { get; set; }
        public int Harga { get; set; }

        public Beli()
        {
            InitializeComponent();
            Judul = "Jasa Editor Video";
            label3.Text = Judul;
            Status = StatusPesanan.BelumBayar;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IsDataValid())
            {
                Pembayaran pembayaranForm = new Pembayaran();
                pembayaranForm.SetHalamanSebelumnya(this);
                pembayaranForm.Show();
                Hide();
            }
        }

        private bool IsDataValid()
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Harap lengkapi semua data sebelum melanjutkan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int inputHarga))
            {
                Harga = inputHarga * 20000;
                label7.Text = Harga.ToString();
                label17.Text = Harga.ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int jumlahHari))
            {
                Durasi = jumlahHari;
                label13.Text = Durasi.ToString();
                label20.Text = Durasi.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Deskripsi = textBox2.Text;
            label22.Text = Deskripsi;
        }
    }
}