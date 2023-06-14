using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace TubesKPL_Kelompok8
{
    public partial class Pembayaran : Form
    {
        private Beli formBeli;

        public Pembayaran()
        {
            InitializeComponent();
            this.Load += Pembayaran_Load;
        }

        public void SetHalamanSebelumnya(Beli halaman)
        {
            formBeli = halaman;
        }

        private void Pembayaran_Load(object sender, EventArgs e)
        {
            if (formBeli != null)
            {
                UpdateFormBeliData();
            }
        }

        private void UpdateFormBeliData()
        {
            label16.Text = formBeli.Judul;
            label17.Text = formBeli.Harga.ToString();
            label20.Text = formBeli.Durasi.ToString();
            label3.Text = formBeli.StatusText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (formBeli != null)
            {
                formBeli.Show();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandlePembayaranBerhasil();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HandlePembayaranBerhasil();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HandlePembayaranBerhasil();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HandlePembayaranBerhasil();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HandlePembayaranBerhasil();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HandlePembayaranBerhasil();
        }

        private void HandlePembayaranBerhasil()
        {
            MessageBox.Show("Pembayaran Berhasil", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateFormBeliData();
            formBeli.Status = Beli.StatusPesanan.SedangDiProses;
            Pesanan formPesanan = new Pesanan(formBeli);
            formPesanan.Show();
            Hide();
        }
    }
}
