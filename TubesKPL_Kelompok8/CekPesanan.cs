namespace TubesKPL_Kelompok8
{
    public enum StatusPesanan { BelumTerbayar, SudahTerbayar, DalamPengerjaan, Selesai, Dibatalkan }
    public sealed partial class CekPesanan : Form
    {
        public string recievedText;
        private static CekPesanan _instance;
        //Table-driven.
        public string GetStatus(StatusPesanan status)
        {
            string[] value =
            {
                "Belum Terbayar",
                "Sudah Terbayar",
                "Dalam Pengerjaan",
                "Selesai",
                "Dibatalkan"
            };
            return value[(int)status];
        }
        private CekPesanan(string recievedText)
        {
            this.recievedText = recievedText;
            InitializeComponent();
        }

        public static CekPesanan GetInstance(string recievedText)
        {
            if (_instance == null)
            {
                _instance = new CekPesanan(recievedText);
            }
            return _instance;
        }

        public void Reload()
        {
            listView.Items.Clear();
            LoginConvig lc = new LoginConvig();
            lc.ReadKonfigFile();
            int idxAkun = lc.SearchAkun(recievedText);
            Akun akun = lc.ListAkun.akun[idxAkun];
            foreach (Pesanan pesanan in akun.penjual.pesanan)
            {
                ListViewItem item = new ListViewItem(pesanan.nama_pesanan);
                item.SubItems.Add(pesanan.status_pesanan);
                item.Tag = pesanan;
                listView.Items.Add(item);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form3.GetInstance(recievedText).Show();
            this.Hide();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                labelNama.Text = "Nama pesanan : ";
                labelJenis.Text = "Jenis pesanan : ";
                labelStatus.Text = "Status pesanan : ";
                labelDesc.Text = "";
                LoginConvig lc = new LoginConvig();
                lc.ReadKonfigFile();
                int idxAkun = lc.SearchAkun(recievedText);
                Akun akun = lc.ListAkun.akun[idxAkun];
                ListViewItem selectedItem = listView.SelectedItems[0];
                string selectedNamaPesanan = selectedItem.Text;
                Pesanan ini = new Pesanan();
                foreach (Pesanan pesanan in akun.penjual.pesanan)
                {
                    if (pesanan.nama_pesanan == selectedNamaPesanan)
                    {
                        ini = pesanan;
                    }
                }
                labelNama.Text += ini.nama_pesanan;
                labelJenis.Text += ini.jenis_jasa;
                labelStatus.Text += ini.status_pesanan;
                labelDesc.Text = ini.deskripsi_pesanan;
            }
        }

        private void buttonKerjakan_Click(object sender, EventArgs e)
        {
            LoginConvig lc = new LoginConvig();
            lc.ReadKonfigFile();
            int idxAkun = lc.SearchAkun(recievedText);
            Akun akun = lc.ListAkun.akun[idxAkun];
            ListViewItem selectedItem = listView.SelectedItems[0];
            string selectedNamaPesanan = selectedItem.Text;
            int idx = -1;
            int i = 0;
            foreach (Pesanan pesanan in akun.penjual.pesanan)
            {
                if (pesanan.nama_pesanan == selectedNamaPesanan)
                {
                    idx = i;
                }
                i++;
            }

            lc.ListAkun.akun[idxAkun].penjual.pesanan[idx].status_pesanan = GetStatus(StatusPesanan.DalamPengerjaan);

            idx = -1;
            i = 0;
            string pemesan = "";
            foreach (Akun akon in lc.ListAkun.akun)
            {
                foreach (Pesanan pesanan in akon.pembeli.pemesanan)
                {
                    if (pesanan.nama_pesanan == selectedNamaPesanan)
                    {
                        idx = i;
                        pemesan = akon.username;
                    }
                    i++;
                }
            }
            idxAkun = lc.SearchAkun(pemesan);
            lc.ListAkun.akun[idxAkun].pembeli.pemesanan[idx].status_pesanan = GetStatus(StatusPesanan.DalamPengerjaan);

            lc.WriteKonfigFile();
            Reload();
        }

        private void buttonSelesai_Click(object sender, EventArgs e)
        {
            LoginConvig lc = new LoginConvig();
            lc.ReadKonfigFile();
            int idxAkun = lc.SearchAkun(recievedText);
            Akun akun = lc.ListAkun.akun[idxAkun];
            ListViewItem selectedItem = listView.SelectedItems[0];
            string selectedNamaPesanan = selectedItem.Text;
            int idx = -1;
            int i = 0;

            foreach (Pesanan pesanan in akun.penjual.pesanan)
            {
                if (pesanan.nama_pesanan == selectedNamaPesanan)
                {
                    idx = i;
                }
                i++;
            }
            lc.ListAkun.akun[idxAkun].penjual.pesanan[idx].status_pesanan = GetStatus(StatusPesanan.Selesai);
            lc.ListAkun.akun[idxAkun].penjual.pesanan.RemoveAt(idx);

            idx = -1;
            i = 0;
            string pemesan = "";
            foreach (Akun akon in lc.ListAkun.akun)
            {
                foreach (Pesanan pesanan in akon.pembeli.pemesanan)
                {
                    if (pesanan.nama_pesanan == selectedNamaPesanan)
                    {
                        idx = i;
                        pemesan = akon.username;
                        break;
                    }
                    i++;
                }
            }
            idxAkun = lc.SearchAkun(pemesan);
            lc.ListAkun.akun[idxAkun].pembeli.pemesanan[idx].status_pesanan = GetStatus(StatusPesanan.Selesai);
            lc.ListAkun.akun[idxAkun].pembeli.pemesanan.RemoveAt(idx);

            lc.WriteKonfigFile();
            Reload();
        }
    }
}