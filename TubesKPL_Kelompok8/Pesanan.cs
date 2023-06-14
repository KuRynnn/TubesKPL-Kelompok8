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
    public partial class Pesanan : Form
    {
        private Beli formBeli;
        public Pesanan(Beli beliForm)
        {
            formBeli = beliForm;
            InitializeComponent();
            this.Load += Pesanan_Load;
        }

        private void Pesanan_Load(object sender, EventArgs e)
        {
            UpdateFormBeliData();
        }
        private void UpdateFormBeliData()
        {
            label16.Text = formBeli.Judul;
            label17.Text = formBeli.Harga.ToString();
            label20.Text = formBeli.Durasi.ToString();
            label3.Text = formBeli.StatusText;

            if (formBeli.Status ==Beli.StatusPesanan.Selesai || formBeli.Status == Beli.StatusPesanan.Dibatalkan)
            {
                button1.Visible = false; // Tombol Batalkan Pesanan
                button3.Visible = false; // Tombol Pesanan Diterima
                button5.Visible = true;  // Tombol Pesan Lagi
            }
            else
            {
                button1.Visible = true;  // Tombol Batalkan Pesanan
                button3.Visible = true;  // Tombol Pesanan Diterima
                button5.Visible = false; // Tombol Pesan Lagi
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formBeli.Status = Beli.StatusPesanan.Selesai;
            MessageBox.Show("Pesanan Diterima", "Diterima", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateFormBeliData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formBeli.Status = Beli.StatusPesanan.Dibatalkan;
            MessageBox.Show("Pesanan Dibatalkan", "Dibatalkan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateFormBeliData();
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
