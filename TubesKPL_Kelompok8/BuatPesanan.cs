namespace TubesKPL_Kelompok8
{
    public sealed partial class BuatPesanan : Form
    {
        public string akun;
        private static BuatPesanan _instance;
        private BuatPesanan(string akun)
        {
            InitializeComponent();
            this.akun = akun;
        }
        public static Form GetInstance(string recievedText)
        {
            if (_instance == null)
            {
                _instance = new BuatPesanan(recievedText);
            }
            return _instance;
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form3.GetInstance(akun).Show();
            this.Hide();
        }

        private void buttonBuatPesanan_Click(object sender, EventArgs e)
        {
            if (textBoxPenyedia.Text == "" || textBoxNamaPesanan.Text == "" ||
                textBoxJenisJasa.Text == "" || richTextBoxDeskripsi.Text == "")
            {
                MessageBox.Show(this, "Semua field harus terisi.", "Isi field!", MessageBoxButtons.OK);
            }
            else
            {
                LoginConvig lc = new LoginConvig();
                lc.ReadKonfigFile();
                int idxAkun = lc.searchAkun(akun);
                int idxPenyedia = lc.searchAkun(textBoxPenyedia.Text);
                iterration.iterration iter = new iterration.iterration();
                if (idxPenyedia != -1)
                {
                    bool ada = false;
                    int i = 0;
                    while (iter.iterate<Akun>(lc.ListAkun.akun, i))
                    {
                        foreach (Akun akun in lc.ListAkun.akun)
                        {
                            foreach (Jasa jasa in akun.penjual.jasa)
                            {
                                if (jasa.jenis_jasa == textBoxJenisJasa.Text)
                                {
                                    ada = true;
                                }
                            }
                        }
                    }


                    if (ada)
                    {
                        Pesanan pesanan = new Pesanan();
                        pesanan.nama_pesanan = textBoxNamaPesanan.Text;
                        pesanan.status_pesanan = "belum terbayar";
                        pesanan.deskripsi_pesanan = richTextBoxDeskripsi.Text;
                        pesanan.jenis_jasa = textBoxJenisJasa.Text;
                        pesanan.akun_penyedia = textBoxPenyedia.Text;
                        DialogResult result = MessageBox.Show(this, "Apakah anda yakin? ", "Konfimasi", MessageBoxButtons.OKCancel);
                        lc.ListAkun.akun[idxAkun].pembeli.pemesanan.Add(pesanan);
                        lc.ListAkun.akun[idxPenyedia].penjual.pesanan.Add(pesanan);
                        lc.WriteKonfigFile();
                        Form3.GetInstance(akun).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(this, "Penyedia tidak menyediakan jasa tersebut.", "Penyedia", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Penyedia tidak ditemukan.", "Penyedia", MessageBoxButtons.OK);
                }
            }
        }

        private void BuatPesanan_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPenyedia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
