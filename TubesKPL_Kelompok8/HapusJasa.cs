using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace TubesKPL_Kelompok8
{
    public sealed partial class HapusJasa : Form
    {
        private string receivedText;
        private static HapusJasa _instance;

        private HapusJasa(string textFromForm3)
        {
            InitializeComponent();
            receivedText = textFromForm3;
        }

        public static HapusJasa GetInstance(string recievedText)
        {
            if (_instance == null)
            {
                _instance = new HapusJasa(recievedText);
            }
            return _instance;
        }

        public void reload()
        {
            listView.Items.Clear();
            UnggahJasaConfig config = new UnggahJasaConfig();
            Akun akun = new Akun();
            akun = config.SearchAkun(receivedText);
            foreach (Jasa jasa in akun.penjual.jasa)
            {
                ListViewItem item = new ListViewItem(jasa.jenis_jasa);
                item.SubItems.Add(jasa.harga.ToString());
                item.SubItems.Add(jasa.deskripsi);
                item.Tag = jasa;
                listView.Items.Add(item);
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];
                string selectedDataJenis = selectedItem.Text;
                labelJenisJasaData.Text = selectedDataJenis;

                string selectedDataHarga = selectedItem.SubItems[1].Text;
                labelHargaData.Text = selectedDataHarga;

                string selectedDataDesc = selectedItem.SubItems[2].Text;
                labelDeskripsiData.Text = selectedDataDesc;
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Apakah anda yakin? ", "Konfimasi", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                UnggahJasaConfig config = new UnggahJasaConfig();
                ListViewItem selectedItem = listView.SelectedItems[0];
                string selectedDataJenis = selectedItem.Text;
                config.HapusData(receivedText, selectedDataJenis);
                if (listView.Items.Count > 0)
                    listView.Items.Remove(listView.SelectedItems[0]);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form3.GetInstance(receivedText).Show();
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
