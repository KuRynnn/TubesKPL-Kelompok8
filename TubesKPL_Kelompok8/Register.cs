﻿using System;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Akun telah terbuat", "Konfimasi", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                UnggahJasaConfig config = new UnggahJasaConfig();
                config.Register(textBoxFullname.Text, textBoxUsername.Text, textBoxEmail.Text, textBoxPassword.Text);
                Login form = new Login();
                form.Show();
                this.Hide();
            }
        }
    }
}
