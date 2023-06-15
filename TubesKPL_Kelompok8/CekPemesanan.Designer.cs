namespace TubesKPL_Kelompok8
{
    partial class CekPemesanan
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
            Jenis_Pesanan = new ColumnHeader();
            Status_Pesanan = new ColumnHeader();
            Deskripsi = new ColumnHeader();
            labelListJasa = new Label();
            labelJudul = new Label();
            buttonMembayar = new Button();
            buttonBatalkan = new Button();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(38, 29);
            buttonBack.Margin = new Padding(6);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(139, 49);
            buttonBack.TabIndex = 36;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { Nama_Pesanan, Jenis_Pesanan, Status_Pesanan, Deskripsi });
            listView.Font = new Font("Arial", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            listView.Location = new Point(54, 230);
            listView.Margin = new Padding(6);
            listView.Name = "listView";
            listView.Size = new Size(539, 382);
            listView.TabIndex = 35;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // Nama_Pesanan
            // 
            Nama_Pesanan.Text = "Nama_Pesanan";
            Nama_Pesanan.Width = 85;
            // 
            // Jenis_Pesanan
            // 
            Jenis_Pesanan.Text = "Jenis_Pesanan";
            Jenis_Pesanan.Width = 75;
            // 
            // Status_Pesanan
            // 
            Status_Pesanan.Text = "Status_Pesanan";
            Status_Pesanan.Width = 173;
            // 
            // Deskripsi
            // 
            Deskripsi.Text = "Deskripsi";
            // 
            // labelListJasa
            // 
            labelListJasa.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelListJasa.Location = new Point(54, 171);
            labelListJasa.Margin = new Padding(6, 0, 6, 0);
            labelListJasa.Name = "labelListJasa";
            labelListJasa.Size = new Size(403, 53);
            labelListJasa.TabIndex = 34;
            labelListJasa.Text = "List Pesanan Anda:";
            // 
            // labelJudul
            // 
            labelJudul.BackColor = Color.LightSeaGreen;
            labelJudul.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelJudul.ForeColor = Color.White;
            labelJudul.Location = new Point(-1, -4);
            labelJudul.Margin = new Padding(6, 0, 6, 0);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(827, 117);
            labelJudul.TabIndex = 33;
            labelJudul.Text = "Cek Pemesanan";
            labelJudul.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonMembayar
            // 
            buttonMembayar.Location = new Point(443, 684);
            buttonMembayar.Name = "buttonMembayar";
            buttonMembayar.Size = new Size(150, 46);
            buttonMembayar.TabIndex = 37;
            buttonMembayar.Text = "Bayar";
            buttonMembayar.UseVisualStyleBackColor = true;
            buttonMembayar.Click += buttonMembayar_Click;
            // 
            // buttonBatalkan
            // 
            buttonBatalkan.Location = new Point(267, 684);
            buttonBatalkan.Name = "buttonBatalkan";
            buttonBatalkan.Size = new Size(150, 46);
            buttonBatalkan.TabIndex = 38;
            buttonBatalkan.Text = "Batalkan";
            buttonBatalkan.UseVisualStyleBackColor = true;
            buttonBatalkan.Click += buttonBatalkan_Click;
            // 
            // CekPemesanan
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 1359);
            Controls.Add(buttonBatalkan);
            Controls.Add(buttonMembayar);
            Controls.Add(buttonBack);
            Controls.Add(listView);
            Controls.Add(labelListJasa);
            Controls.Add(labelJudul);
            Name = "CekPemesanan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CekPemesanan";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBack;
        private ListView listView;
        private ColumnHeader Jenis_Pesanan;
        private ColumnHeader Nama_Pesanan;
        private ColumnHeader Status_Pesanan;
        private ColumnHeader Deskripsi;
        private Label labelListJasa;
        private Label labelJudul;
        private Button buttonMembayar;
        private Button buttonBatalkan;
    }
}