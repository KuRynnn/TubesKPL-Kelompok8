namespace TubesKPL_Kelompok8
{
    partial class BuatPesanan
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
            labelJudul = new Label();
            label1 = new Label();
            textBoxPenyedia = new TextBox();
            textBoxJenisJasa = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxNamaPesanan = new TextBox();
            label4 = new Label();
            richTextBoxDeskripsi = new RichTextBox();
            buttonBuatPesanan = new Button();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(23, 16);
            buttonBack.Margin = new Padding(4, 4, 4, 4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(86, 31);
            buttonBack.TabIndex = 34;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelJudul
            // 
            labelJudul.BackColor = Color.LightSeaGreen;
            labelJudul.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelJudul.ForeColor = Color.White;
            labelJudul.Location = new Point(-1, -4);
            labelJudul.Margin = new Padding(4, 0, 4, 0);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(473, 73);
            labelJudul.TabIndex = 33;
            labelJudul.Text = "Buat Pesanan";
            labelJudul.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 155);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 35;
            label1.Text = "Penyedia : ";
            // 
            // textBoxPenyedia
            // 
            textBoxPenyedia.Location = new Point(155, 153);
            textBoxPenyedia.Margin = new Padding(2, 2, 2, 2);
            textBoxPenyedia.Name = "textBoxPenyedia";
            textBoxPenyedia.Size = new Size(205, 27);
            textBoxPenyedia.TabIndex = 36;
            textBoxPenyedia.TextChanged += textBoxPenyedia_TextChanged;
            // 
            // textBoxJenisJasa
            // 
            textBoxJenisJasa.Location = new Point(155, 201);
            textBoxJenisJasa.Margin = new Padding(2, 2, 2, 2);
            textBoxJenisJasa.Name = "textBoxJenisJasa";
            textBoxJenisJasa.Size = new Size(205, 27);
            textBoxJenisJasa.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 202);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 37;
            label2.Text = "Jenis Jasa :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 293);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 41;
            label3.Text = "Deskripsi : ";
            // 
            // textBoxNamaPesanan
            // 
            textBoxNamaPesanan.Location = new Point(155, 244);
            textBoxNamaPesanan.Margin = new Padding(2, 2, 2, 2);
            textBoxNamaPesanan.Name = "textBoxNamaPesanan";
            textBoxNamaPesanan.Size = new Size(205, 27);
            textBoxNamaPesanan.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 246);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 39;
            label4.Text = "Nama Pesanan :";
            // 
            // richTextBoxDeskripsi
            // 
            richTextBoxDeskripsi.Location = new Point(155, 291);
            richTextBoxDeskripsi.Margin = new Padding(2, 2, 2, 2);
            richTextBoxDeskripsi.Name = "richTextBoxDeskripsi";
            richTextBoxDeskripsi.Size = new Size(205, 122);
            richTextBoxDeskripsi.TabIndex = 43;
            richTextBoxDeskripsi.Text = "";
            // 
            // buttonBuatPesanan
            // 
            buttonBuatPesanan.Location = new Point(266, 494);
            buttonBuatPesanan.Margin = new Padding(2, 2, 2, 2);
            buttonBuatPesanan.Name = "buttonBuatPesanan";
            buttonBuatPesanan.Size = new Size(92, 29);
            buttonBuatPesanan.TabIndex = 44;
            buttonBuatPesanan.Text = "Buat Pesanan";
            buttonBuatPesanan.UseVisualStyleBackColor = true;
            buttonBuatPesanan.Click += buttonBuatPesanan_Click;
            // 
            // BuatPesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 659);
            Controls.Add(buttonBuatPesanan);
            Controls.Add(richTextBoxDeskripsi);
            Controls.Add(label3);
            Controls.Add(textBoxNamaPesanan);
            Controls.Add(label4);
            Controls.Add(textBoxJenisJasa);
            Controls.Add(label2);
            Controls.Add(textBoxPenyedia);
            Controls.Add(label1);
            Controls.Add(buttonBack);
            Controls.Add(labelJudul);
            Margin = new Padding(2, 2, 2, 2);
            Name = "BuatPesanan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuatPesanan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private Label labelJudul;
        private Label label1;
        private TextBox textBoxPenyedia;
        private TextBox textBoxJenisJasa;
        private Label label2;
        private Label label3;
        private TextBox textBoxNamaPesanan;
        private Label label4;
        private RichTextBox richTextBoxDeskripsi;
        private Button buttonBuatPesanan;
    }
}