using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace TubesKPL_Kelompok8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UnggahJasaConfig config = new UnggahJasaConfig();
            Akun akun = new Akun();
            akun = config.searchAkun("Admin");
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
                config.hapusData("Admin", selectedDataJenis);
                if (listView.Items.Count > 0)
                    listView.Items.Remove(listView.SelectedItems[0]);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
