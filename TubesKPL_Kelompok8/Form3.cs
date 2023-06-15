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
    public enum AkunState { Penjual, Pembeli, Logout }
    public enum Trigger { switchMode, keluar }
    public enum PilihanMenu
    {
        TambahJasa, CekPesanan, HapusJasa,
        CariJasa, BuatPemesanan, CekPemesanan,
        EditProfile
    }
    public sealed partial class Form3 : Form
    {
        private string receivedText;
        AkunState currentState;
        private static Form3 _instance;
        private Form3(string textInput)
        {
            InitializeComponent();
            receivedText = textInput;

            labelUser.Text = receivedText;
            currentState = AkunState.Penjual;
        }

        public static Form GetInstance(string recievedText)
        {
            if (_instance == null)
            {
                _instance = new Form3(recievedText);
            }
            return _instance;
        }

        public Form3()
        {
            InitializeComponent();
            currentState = AkunState.Penjual;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //State-based start.
        class Transition
        {
            public AkunState stateAwal;
            public AkunState stateAkhir;
            public Trigger trigger;
            public Transition(AkunState stateAwal, AkunState stateAkhir, Trigger trigger)
            {
                this.stateAwal = stateAwal;
                this.stateAkhir = stateAkhir;
                this.trigger = trigger;
            }
        }
        Transition[] transitions =
        {
            new Transition(AkunState.Pembeli, AkunState.Penjual, Trigger.switchMode),
            new Transition(AkunState.Penjual, AkunState.Pembeli, Trigger.switchMode),
            new Transition(AkunState.Penjual, AkunState.Logout, Trigger.keluar),
            new Transition(AkunState.Pembeli, AkunState.Logout, Trigger.keluar)
        };
        public AkunState getNextState(AkunState prevState, Trigger trigger)
        {
            AkunState nextState = prevState;
            foreach (var transition in transitions)
            {
                if (transition.stateAwal == prevState && transition.trigger == trigger)
                {
                    nextState = transition.stateAkhir;
                }
            }
            if (nextState == AkunState.Penjual)
            {
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }
            else if (nextState == AkunState.Pembeli)
            {
                tabControl1.SelectedTab = tabControl1.TabPages[1];
            }
            else
            {
                Application.Exit();
            }
            return nextState;
        }
        //State-based end.

        //Table-driven start.
        public void GetMenus(PilihanMenu posisi)
        {
            Form[] value =
            {
                UnggahJasa.GetInstance(receivedText),
                CekPesanan.GetInstance(receivedText), //masukin form cek pesanan disini
                HapusJasa.GetInstance(receivedText),
                CariJasa.GetInstance(receivedText), //cari jasa form
                BuatPesanan.GetInstance(receivedText), //buat pemesanan form
                CekPemesanan.GetInstance(receivedText), //cek pemesanan
                EditProfile.GetInstance(receivedText)
                //Disini bikin objek menu kalian sesuai enum.
            };
            value[(int)posisi].Show();
            this.Hide();
            //return value[(int)posisi];
        }
        //Table-driven end.
        private void buttonBeralih_Click(object sender, EventArgs e)
        {
            currentState = getNextState(currentState, Trigger.switchMode);
        }

        private void buttonBeralih2_Click(object sender, EventArgs e)
        {
            currentState = getNextState(currentState, Trigger.switchMode);
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            currentState = getNextState(currentState, Trigger.keluar);
        }

        private void buttonKeluar2_Click(object sender, EventArgs e)
        {
            currentState = getNextState(currentState, Trigger.keluar);
        }

        private void buttonHapusJasa_Click(object sender, EventArgs e)
        {
            GetMenus(PilihanMenu.HapusJasa);
            HapusJasa hj = HapusJasa.GetInstance(receivedText);
            hj.reload();
        }

        private void buttonEditProfil_Click(object sender, EventArgs e)
        {
            GetMenus(PilihanMenu.EditProfile);
        }

        private void buttonTambahJasa_Click(object sender, EventArgs e)
        {
            GetMenus(PilihanMenu.TambahJasa);
        }

        private void buttonEditProfil_Click1(object sender, EventArgs e)
        {
            GetMenus(PilihanMenu.EditProfile);
        }

        private void buttonCekPesanan_Click(object sender, EventArgs e)
        {
            GetMenus(PilihanMenu.CekPesanan);
            CekPesanan cp = CekPesanan.GetInstance(receivedText);
            cp.Reload();
        }

        private void buttonCariJasa_Click(object sender, EventArgs e)
        {
            GetMenus(PilihanMenu.CariJasa);
            CariJasa cj = CariJasa.GetInstance(receivedText);
            cj.reload();
        }

        private void buttonBuatPemesanan_Click(object sender, EventArgs e)
        {
            GetMenus(PilihanMenu.BuatPemesanan);
        }

        private void buttonCekPemesanan_Click(object sender, EventArgs e)
        {
            GetMenus(PilihanMenu.CekPemesanan);
            CekPemesanan cp = CekPemesanan.GetInstance(receivedText);
            cp.Reload();
        }
    }
}

