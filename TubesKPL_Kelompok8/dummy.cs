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
    public partial class dummy : Form
    {
        private Form parent;

        public dummy(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void dummy_Load(object sender, EventArgs e)
        {

        }
    }
}
