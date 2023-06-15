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
    public sealed partial class CariJasa : Form
    {
        private string recievedText;
        private static CariJasa _instance;
        private CariJasa(string recievedText)
        {
            InitializeComponent();
            this.recievedText = recievedText;
        }

        public static CariJasa GetInstance(string recievedText)
        {
            if (_instance == null)
            {
                _instance = new CariJasa(recievedText);
            }
            return _instance;
        }

        public void reload()
        {
            listView.Items.Clear();
            LoginConvig lc = new LoginConvig();
            lc.ReadKonfigFile();
            foreach (Akun akun in lc.ListAkun.akun)
            {
                foreach (Jasa jasa in akun.penjual.jasa)
                {
                    ListViewItem item = new ListViewItem(akun.username);
                    item.SubItems.Add(jasa.jenis_jasa);
                    item.SubItems.Add(jasa.harga.ToString());
                    item.SubItems.Add(jasa.deskripsi);
                    item.Tag = jasa;
                    listView.Items.Add(item);
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form3.GetInstance(recievedText).Show();
            this.Hide();
        }
    }
}
