namespace TubesKPL_Kelompok8
{
    public sealed partial class UnggahJasa : Form
    {
        private string receivedText;
        private static UnggahJasa _instance;
        private UnggahJasa(string textFromForm3)
        {
            InitializeComponent();
            receivedText = textFromForm3;
        }

        public static UnggahJasa GetInstance(string textFromForm3)
        {
            if (_instance == null)
            {
                _instance = new UnggahJasa(textFromForm3);
            }
            return _instance;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Apakah anda yakin? ", "Konfimasi", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                UnggahJasaConfig config = new UnggahJasaConfig();
                config.TambahData(receivedText, textBoxServiceName.Text, int.Parse(textBoxPrice.Text), richTextBox1.Text);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form3.GetInstance(receivedText).Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}