namespace TubesKPL_Kelompok8
{
    partial class Form2
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
            btnHapus = new Button();
            labelDeskripsiData = new Label();
            labelHargaData = new Label();
            labelJenisJasaData = new Label();
            labelDeskripsi = new Label();
            labelHarga = new Label();
            labelJenisJasa = new Label();
            labelData = new Label();
            listView = new ListView();
            Jenis_Jasa = new ColumnHeader();
            Harga = new ColumnHeader();
            Deskripsi = new ColumnHeader();
            labelListJasa = new Label();
            labelJudul = new Label();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(12, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 28;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // btnHapus
            // 
            btnHapus.Font = new Font("Arial", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnHapus.Location = new Point(290, 601);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(75, 23);
            btnHapus.TabIndex = 27;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // labelDeskripsiData
            // 
            labelDeskripsiData.Font = new Font("Arial", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            labelDeskripsiData.Location = new Point(28, 459);
            labelDeskripsiData.Name = "labelDeskripsiData";
            labelDeskripsiData.Size = new Size(337, 83);
            labelDeskripsiData.TabIndex = 26;
            // 
            // labelHargaData
            // 
            labelHargaData.AutoSize = true;
            labelHargaData.Font = new Font("Arial", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            labelHargaData.Location = new Point(126, 390);
            labelHargaData.Name = "labelHargaData";
            labelHargaData.Size = new Size(0, 16);
            labelHargaData.TabIndex = 25;
            // 
            // labelJenisJasaData
            // 
            labelJenisJasaData.AutoSize = true;
            labelJenisJasaData.Font = new Font("Arial", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            labelJenisJasaData.Location = new Point(126, 355);
            labelJenisJasaData.Name = "labelJenisJasaData";
            labelJenisJasaData.Size = new Size(0, 16);
            labelJenisJasaData.TabIndex = 24;
            // 
            // labelDeskripsi
            // 
            labelDeskripsi.AutoSize = true;
            labelDeskripsi.Font = new Font("Arial", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            labelDeskripsi.Location = new Point(28, 429);
            labelDeskripsi.Name = "labelDeskripsi";
            labelDeskripsi.Size = new Size(72, 16);
            labelDeskripsi.TabIndex = 23;
            labelDeskripsi.Text = "Deskripsi: ";
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.Font = new Font("Arial", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            labelHarga.Location = new Point(28, 390);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(53, 16);
            labelHarga.TabIndex = 22;
            labelHarga.Text = "Harga: ";
            // 
            // labelJenisJasa
            // 
            labelJenisJasa.AutoSize = true;
            labelJenisJasa.Font = new Font("Arial", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            labelJenisJasa.Location = new Point(28, 355);
            labelJenisJasa.Name = "labelJenisJasa";
            labelJenisJasa.Size = new Size(81, 16);
            labelJenisJasa.TabIndex = 21;
            labelJenisJasa.Text = "Jenis Jasa: ";
            // 
            // labelData
            // 
            labelData.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelData.Location = new Point(28, 316);
            labelData.Name = "labelData";
            labelData.Size = new Size(337, 25);
            labelData.TabIndex = 20;
            labelData.Text = "Data:";
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { Jenis_Jasa, Harga, Deskripsi });
            listView.Font = new Font("Arial", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            listView.Location = new Point(28, 111);
            listView.Name = "listView";
            listView.Size = new Size(337, 181);
            listView.TabIndex = 19;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // Jenis_Jasa
            // 
            Jenis_Jasa.Text = "Jenis Jasa";
            Jenis_Jasa.Width = 85;
            // 
            // Harga
            // 
            Harga.Text = "Harga";
            Harga.Width = 75;
            // 
            // Deskripsi
            // 
            Deskripsi.Text = "Deskripsi";
            Deskripsi.Width = 173;
            // 
            // labelListJasa
            // 
            labelListJasa.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelListJasa.Location = new Point(28, 83);
            labelListJasa.Name = "labelListJasa";
            labelListJasa.Size = new Size(337, 25);
            labelListJasa.TabIndex = 18;
            labelListJasa.Text = "List Jasa Akun:";
            // 
            // labelJudul
            // 
            labelJudul.BackColor = Color.LightSeaGreen;
            labelJudul.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelJudul.ForeColor = Color.White;
            labelJudul.Location = new Point(-9, -3);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(414, 55);
            labelJudul.TabIndex = 17;
            labelJudul.Text = "Hapus Jasa";
            labelJudul.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 857);
            Controls.Add(buttonBack);
            Controls.Add(btnHapus);
            Controls.Add(labelDeskripsiData);
            Controls.Add(labelHargaData);
            Controls.Add(labelJenisJasaData);
            Controls.Add(labelDeskripsi);
            Controls.Add(labelHarga);
            Controls.Add(labelJenisJasa);
            Controls.Add(labelData);
            Controls.Add(listView);
            Controls.Add(labelListJasa);
            Controls.Add(labelJudul);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private Button btnHapus;
        private Label labelDeskripsiData;
        private Label labelHargaData;
        private Label labelJenisJasaData;
        private Label labelDeskripsi;
        private Label labelHarga;
        private Label labelJenisJasa;
        private Label labelData;
        private ListView listView;
        private ColumnHeader Jenis_Jasa;
        private ColumnHeader Harga;
        private ColumnHeader Deskripsi;
        private Label labelListJasa;
        private Label labelJudul;
    }
}