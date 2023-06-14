using System.Diagnostics;

namespace TubesKPL_Kelompok8
{
    public enum AkunState { Penjual, Pembeli, Logout }
    public enum Trigger { switchMode, keluar }
    public enum PilihanMenu
    {
        TambahJasa, CekPesanan, TampilkanJasa,
        CariJasa, BuatPemesanan, CekPemesanan,
        EditProfile
    }
    public partial class Form1 : Form
    {
        AkunState currentState;

        public Form1()
        {
            InitializeComponent();
            currentState = AkunState.Penjual;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxProfile.Image = new Bitmap("C:\\Users\\USER\\Downloads\\pngwing.com.png");
            buttonKeluar.Image = new Bitmap("C:\\Users\\USER\\Downloads\\pngwing.com.png");
            buttonKeluar2.Image = new Bitmap("C:\\Users\\USER\\Downloads\\pngwing.com.png");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }

        private void buttonBeralih_Click(object sender, EventArgs e)
        {
            currentState = getNextState(currentState, Trigger.switchMode);
        }

        private void buttonBeralih2_Click(object sender, EventArgs e)
        {
            currentState = getNextState(currentState, Trigger.switchMode);
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
        public void getMenus(PilihanMenu posisi)
        {
            Form[] value =
                {
                    new dummy(), new dummy(),new dummy(),
                    new dummy(), new dummy(),new dummy(),
                    new dummy()
                    //Disini bikin objek menu kalian sesuai enum.
                };
            value[(int)posisi].Show();
            //return value[(int)posisi];
        }
        //Table-driven end.
        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            currentState = getNextState(currentState, Trigger.keluar);
        }

        private void buttonKeluar2_Click(object sender, EventArgs e)
        {
            currentState = getNextState(currentState, Trigger.keluar);
        }

        private void buttonTambahJasa_Click(object sender, EventArgs e)
        {
            getMenus(PilihanMenu.TambahJasa);
            this.Hide();
        }
    }
}