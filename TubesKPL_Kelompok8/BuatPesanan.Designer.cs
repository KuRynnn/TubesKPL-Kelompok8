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
            buttonBack.Location = new Point(38, 26);
            buttonBack.Margin = new Padding(6);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(139, 49);
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
            labelJudul.Location = new Point(-1, -6);
            labelJudul.Margin = new Padding(6, 0, 6, 0);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(769, 117);
            labelJudul.TabIndex = 33;
            labelJudul.Text = "Buat Pesanan";
            labelJudul.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 248);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 35;
            label1.Text = "Penyedia : ";
            // 
            // textBoxPenyedia
            // 
            textBoxPenyedia.Location = new Point(252, 245);
            textBoxPenyedia.Name = "textBoxPenyedia";
            textBoxPenyedia.Size = new Size(330, 39);
            textBoxPenyedia.TabIndex = 36;
            // 
            // textBoxJenisJasa
            // 
            textBoxJenisJasa.Location = new Point(252, 321);
            textBoxJenisJasa.Name = "textBoxJenisJasa";
            textBoxJenisJasa.Size = new Size(330, 39);
            textBoxJenisJasa.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 324);
            label2.Name = "label2";
            label2.Size = new Size(128, 32);
            label2.TabIndex = 37;
            label2.Text = "Jenis Jasa :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 469);
            label3.Name = "label3";
            label3.Size = new Size(129, 32);
            label3.TabIndex = 41;
            label3.Text = "Deskripsi : ";
            // 
            // textBoxNamaPesanan
            // 
            textBoxNamaPesanan.Location = new Point(252, 390);
            textBoxNamaPesanan.Name = "textBoxNamaPesanan";
            textBoxNamaPesanan.Size = new Size(330, 39);
            textBoxNamaPesanan.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 393);
            label4.Name = "label4";
            label4.Size = new Size(183, 32);
            label4.TabIndex = 39;
            label4.Text = "Nama Pesanan :";
            // 
            // richTextBoxDeskripsi
            // 
            richTextBoxDeskripsi.Location = new Point(252, 466);
            richTextBoxDeskripsi.Name = "richTextBoxDeskripsi";
            richTextBoxDeskripsi.Size = new Size(330, 192);
            richTextBoxDeskripsi.TabIndex = 43;
            richTextBoxDeskripsi.Text = "";
            // 
            // buttonBuatPesanan
            // 
            buttonBuatPesanan.Location = new Point(432, 790);
            buttonBuatPesanan.Name = "buttonBuatPesanan";
            buttonBuatPesanan.Size = new Size(150, 46);
            buttonBuatPesanan.TabIndex = 44;
            buttonBuatPesanan.Text = "Buat Pesanan";
            buttonBuatPesanan.UseVisualStyleBackColor = true;
            buttonBuatPesanan.Click += buttonBuatPesanan_Click;
            // 
            // BuatPesanan
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 1359);
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