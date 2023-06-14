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
    public partial class Pembayaran : Form
    {
        private Form Beli;
        private Beli formBeli;
        public Pembayaran()
        {
            InitializeComponent();
            formBeli = new Beli(); // Inisialisasi objek Beli
            this.Load += new System.EventHandler(this.Pembayaran_Load);
        }
        public void SetHalamanSebelumnya(Beli halaman)
        {
            formBeli = halaman;
        }
        private void Pembayaran_Load(object sender, EventArgs e)
        {
            if (formBeli != null)
            {
                label16.Text = formBeli.judul; // Menampilkan judul dari objek Beli pada label16
                label17.Text = formBeli.harga.ToString(); // Menampilkan harga dari objek Beli pada label17
                label20.Text = formBeli.durasi.ToString();
                label3.Text = "Belum Bayar";
                formBeli.Text = label3.Text;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (formBeli != null)
            {
                formBeli.Show(); // Menampilkan halaman sebelumnya
                this.Close(); // Menutup halaman saat ini
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
