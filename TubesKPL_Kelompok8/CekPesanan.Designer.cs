namespace TubesKPL_Kelompok8
{
    partial class CekPesanan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonBack = new Button();
            listView = new ListView();
            Nama_Pesanan = new ColumnHeader();
            Status_Pesanan = new ColumnHeader();
            labelListPesanan = new Label();
            labelJudul = new Label();
            labelNama = new Label();
            labelJenis = new Label();
            labelStatus = new Label();
            labelDeskripsi = new Label();
            labelDesc = new Label();
            buttonKerjakan = new Button();
            buttonSelesai = new Button();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(21, 13);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 32;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { Nama_Pesanan, Status_Pesanan });
            listView.Font = new Font("Arial", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            listView.Location = new Point(30, 108);
            listView.Name = "listView";
            listView.Size = new Size(292, 181);
            listView.TabIndex = 31;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // Nama_Pesanan
            // 
            Nama_Pesanan.Text = "Nama_Pesanan";
            Nama_Pesanan.Width = 85;
            // 
            // Status_Pesanan
            // 
            Status_Pesanan.Text = "Status_Pesanan";
            Status_Pesanan.Width = 173;
            // 
            // labelListPesanan
            // 
            labelListPesanan.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelListPesanan.Location = new Point(30, 80);
            labelListPesanan.Name = "labelListPesanan";
            labelListPesanan.Size = new Size(184, 25);
            labelListPesanan.TabIndex = 30;
            labelListPesanan.Text = "List Pesanan:";
            // 
            // labelJudul
            // 
            labelJudul.BackColor = Color.LightSeaGreen;
            labelJudul.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelJudul.ForeColor = Color.White;
            labelJudul.Location = new Point(0, -2);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(414, 55);
            labelJudul.TabIndex = 29;
            labelJudul.Text = "Cek Pesanan";
            labelJudul.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(30, 309);
            labelNama.Margin = new Padding(2, 0, 2, 0);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(95, 15);
            labelNama.TabIndex = 33;
            labelNama.Text = "Nama Pesanan : ";
            // 
            // labelJenis
            // 
            labelJenis.AutoSize = true;
            labelJenis.Location = new Point(30, 335);
            labelJenis.Margin = new Padding(2, 0, 2, 0);
            labelJenis.Name = "labelJenis";
            labelJenis.Size = new Size(88, 15);
            labelJenis.TabIndex = 34;
            labelJenis.Text = "Jenis Pesanan : ";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(30, 362);
            labelStatus.Margin = new Padding(2, 0, 2, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(95, 15);
            labelStatus.TabIndex = 35;
            labelStatus.Text = "Status Pesanan : ";
            // 
            // labelDeskripsi
            // 
            labelDeskripsi.AutoSize = true;
            labelDeskripsi.Location = new Point(30, 387);
            labelDeskripsi.Margin = new Padding(2, 0, 2, 0);
            labelDeskripsi.Name = "labelDeskripsi";
            labelDeskripsi.Size = new Size(60, 15);
            labelDeskripsi.TabIndex = 36;
            labelDeskripsi.Text = "Deskripsi :";
            // 
            // labelDesc
            // 
            labelDesc.Location = new Point(30, 402);
            labelDesc.Margin = new Padding(2, 0, 2, 0);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(184, 94);
            labelDesc.TabIndex = 37;
            // 
            // buttonKerjakan
            // 
            buttonKerjakan.Location = new Point(151, 432);
            buttonKerjakan.Margin = new Padding(2, 1, 2, 1);
            buttonKerjakan.Name = "buttonKerjakan";
            buttonKerjakan.Size = new Size(81, 22);
            buttonKerjakan.TabIndex = 38;
            buttonKerjakan.Text = "Kerjakan";
            buttonKerjakan.UseVisualStyleBackColor = true;
            buttonKerjakan.Click += buttonKerjakan_Click;
            // 
            // buttonSelesai
            // 
            buttonSelesai.Location = new Point(241, 432);
            buttonSelesai.Margin = new Padding(2, 1, 2, 1);
            buttonSelesai.Name = "buttonSelesai";
            buttonSelesai.Size = new Size(81, 22);
            buttonSelesai.TabIndex = 39;
            buttonSelesai.Text = "Selesai";
            buttonSelesai.UseVisualStyleBackColor = true;
            buttonSelesai.Click += buttonSelesai_Click;
            // 
            // CekPesanan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 497);
            Controls.Add(buttonSelesai);
            Controls.Add(buttonKerjakan);
            Controls.Add(labelDesc);
            Controls.Add(labelDeskripsi);
            Controls.Add(labelStatus);
            Controls.Add(labelJenis);
            Controls.Add(labelNama);
            Controls.Add(buttonBack);
            Controls.Add(listView);
            Controls.Add(labelListPesanan);
            Controls.Add(labelJudul);
            Margin = new Padding(2, 1, 2, 1);
            Name = "CekPesanan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CekPesanan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private ListView listView;
        private ColumnHeader Nama_Pesanan;
        private ColumnHeader Status_Pesanan;
        private Label labelListPesanan;
        private Label labelJudul;
        private Label labelNama;
        private Label labelJenis;
        private Label labelStatus;
        private Label labelDeskripsi;
        private Label labelDesc;
        private Button buttonKerjakan;
        private Button buttonSelesai;
    }
}