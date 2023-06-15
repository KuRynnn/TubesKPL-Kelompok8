using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TubesKPL_Kelompok8
{
    public sealed partial class CekPemesanan : Form
    {
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
        private string recievedText;
        private static CekPemesanan _instance;
        private CekPemesanan(string recievedText)
        {
            this.recievedText = recievedText;
            InitializeComponent();
        }

        public static CekPemesanan GetInstance(string recievedText)
        {
            if (_instance == null)
            {
                _instance = new CekPemesanan(recievedText);
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
            foreach (Pesanan pesanan in akun.pembeli.pemesanan)
            {
                ListViewItem item = new ListViewItem(pesanan.nama_pesanan);
                item.SubItems.Add(pesanan.jenis_jasa);
                item.SubItems.Add(pesanan.status_pesanan);
                item.SubItems.Add(pesanan.deskripsi_pesanan);
                item.Tag = pesanan;
                listView.Items.Add(item);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form3.GetInstance(recievedText).Show();
            this.Hide();
        }

        private void buttonBatalkan_Click(object sender, EventArgs e)
        {
            LoginConvig lc = new LoginConvig();
            lc.ReadKonfigFile();
            int idxAkun = lc.SearchAkun(recievedText);
            Akun akun = lc.ListAkun.akun[idxAkun];
            ListViewItem selectedItem = listView.SelectedItems[0];
            string selectedNamaPesanan = selectedItem.Text;
            string penyedia = "";
            int idx = -1; int i = 0;
            foreach (Pesanan pesanan in akun.pembeli.pemesanan)
            {
                if (pesanan.nama_pesanan == selectedNamaPesanan)
                {
                    idx = i;
                    penyedia = pesanan.akun_penyedia;
                }
                i++;
            }

            lc.ListAkun.akun[idxAkun].pembeli.pemesanan[idx].status_pesanan = GetStatus(StatusPesanan.Dibatalkan);
            lc.ListAkun.akun[idxAkun].pembeli.pemesanan.RemoveAt(idx);

            idxAkun = lc.SearchAkun(penyedia);
            akun = lc.ListAkun.akun[idxAkun];
            idx = -1; i = 0;
            foreach (Pesanan pesanan in akun.penjual.pesanan)
            {
                if (pesanan.nama_pesanan == selectedNamaPesanan)
                {
                    idx = i;
                }
                i++;
            }

            lc.ListAkun.akun[idxAkun].penjual.pesanan[idx].status_pesanan = GetStatus(StatusPesanan.Dibatalkan);
            lc.ListAkun.akun[idxAkun].penjual.pesanan.RemoveAt(idx);

            lc.WriteKonfigFile();
            Reload();
        }

        private void buttonMembayar_Click(object sender, EventArgs e)
        {
            LoginConvig lc = new LoginConvig();
            lc.ReadKonfigFile();
            int idxAkun = lc.SearchAkun(recievedText);
            Akun akun = lc.ListAkun.akun[idxAkun];
            ListViewItem selectedItem = listView.SelectedItems[0];
            string selectedNamaPesanan = selectedItem.Text;
            string penyedia = "";
            int idx = -1; int i = 0;
            foreach (Pesanan pesanan in akun.pembeli.pemesanan)
            {
                if (pesanan.nama_pesanan == selectedNamaPesanan)
                {
                    idx = i;
                    penyedia = pesanan.akun_penyedia;
                }
                i++;
            }

            lc.ListAkun.akun[idxAkun].pembeli.pemesanan[idx].status_pesanan = GetStatus(StatusPesanan.SudahTerbayar);

            idxAkun = lc.SearchAkun(penyedia);
            akun = lc.ListAkun.akun[idxAkun];
            idx = -1; i = 0;
            foreach (Pesanan pesanan in akun.penjual.pesanan)
            {
                if (pesanan.nama_pesanan == selectedNamaPesanan)
                {
                    idx = i;
                }
                i++;
            }

            lc.ListAkun.akun[idxAkun].penjual.pesanan[idx].status_pesanan = GetStatus(StatusPesanan.SudahTerbayar);
            lc.WriteKonfigFile();
            Reload();
        }
    }
}