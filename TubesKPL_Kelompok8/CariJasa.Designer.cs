﻿namespace TubesKPL_Kelompok8
{
    partial class CariJasa
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
            Nama_Penyedia = new ColumnHeader();
            Jenis_Jasa = new ColumnHeader();
            Harga_Jasa = new ColumnHeader();
            Deskripsi = new ColumnHeader();
            labelListJasa = new Label();
            labelJudul = new Label();
            textBoxPencarian = new TextBox();
            buttonCari = new Button();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(37, 28);
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
            listView.Columns.AddRange(new ColumnHeader[] { Nama_Penyedia, Jenis_Jasa, Harga_Jasa, Deskripsi });
            listView.Font = new Font("Arial", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            listView.Location = new Point(53, 230);
            listView.Margin = new Padding(6);
            listView.Name = "listView";
            listView.Size = new Size(539, 382);
            listView.TabIndex = 35;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // Nama_Penyedia
            // 
            Nama_Penyedia.Text = "Nama_Penyedia";
            Nama_Penyedia.Width = 85;
            // 
            // Jenis_Jasa
            // 
            Jenis_Jasa.Text = "Jenis_Jasa";
            Jenis_Jasa.Width = 75;
            // 
            // Harga_Jasa
            // 
            Harga_Jasa.Text = "Harga_Jasa";
            Harga_Jasa.Width = 173;
            // 
            // Deskripsi
            // 
            Deskripsi.Text = "Deskripsi";
            // 
            // labelListJasa
            // 
            labelListJasa.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelListJasa.Location = new Point(53, 170);
            labelListJasa.Margin = new Padding(6, 0, 6, 0);
            labelListJasa.Name = "labelListJasa";
            labelListJasa.Size = new Size(378, 53);
            labelListJasa.TabIndex = 34;
            labelListJasa.Text = "List Jasa Tersedia:";
            // 
            // labelJudul
            // 
            labelJudul.BackColor = Color.LightSeaGreen;
            labelJudul.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelJudul.ForeColor = Color.White;
            labelJudul.Location = new Point(-2, -5);
            labelJudul.Margin = new Padding(6, 0, 6, 0);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(769, 117);
            labelJudul.TabIndex = 33;
            labelJudul.Text = "Cari Jasa";
            labelJudul.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxPencarian
            // 
            textBoxPencarian.Location = new Point(53, 698);
            textBoxPencarian.Name = "textBoxPencarian";
            textBoxPencarian.Size = new Size(353, 39);
            textBoxPencarian.TabIndex = 37;
            // 
            // buttonCari
            // 
            buttonCari.Location = new Point(442, 691);
            buttonCari.Name = "buttonCari";
            buttonCari.Size = new Size(150, 46);
            buttonCari.TabIndex = 38;
            buttonCari.Text = "Cari";
            buttonCari.UseVisualStyleBackColor = true;
            buttonCari.Click += buttonCari_Click;
            // 
            // CariJasa
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 1359);
            Controls.Add(buttonCari);
            Controls.Add(textBoxPencarian);
            Controls.Add(buttonBack);
            Controls.Add(listView);
            Controls.Add(labelListJasa);
            Controls.Add(labelJudul);
            Name = "CariJasa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CariJasa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private ListView listView;
        private ColumnHeader Nama_Penyedia;
        private ColumnHeader Jenis_Jasa;
        private ColumnHeader Harga_Jasa;
        private ColumnHeader Deskripsi;
        private Label labelListJasa;
        private Label labelJudul;
        private TextBox textBoxPencarian;
        private Button buttonCari;
    }
}