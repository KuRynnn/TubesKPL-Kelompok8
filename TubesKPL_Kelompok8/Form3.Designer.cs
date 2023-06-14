namespace TubesKPL_Kelompok8
{
    partial class Form3
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
            buttonHapusJasa = new Button();
            buttonUnggahJasa = new Button();
            labelJudul = new Label();
            SuspendLayout();
            // 
            // buttonHapusJasa
            // 
            buttonHapusJasa.BackColor = Color.LightSeaGreen;
            buttonHapusJasa.FlatStyle = FlatStyle.Flat;
            buttonHapusJasa.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHapusJasa.ForeColor = Color.White;
            buttonHapusJasa.Location = new Point(209, 288);
            buttonHapusJasa.Margin = new Padding(3, 2, 3, 2);
            buttonHapusJasa.Name = "buttonHapusJasa";
            buttonHapusJasa.Size = new Size(139, 134);
            buttonHapusJasa.TabIndex = 19;
            buttonHapusJasa.Text = "Hapus Jasa";
            buttonHapusJasa.UseVisualStyleBackColor = false;
            buttonHapusJasa.Click += buttonHapusJasa_Click;
            // 
            // buttonUnggahJasa
            // 
            buttonUnggahJasa.BackColor = Color.LightSeaGreen;
            buttonUnggahJasa.FlatStyle = FlatStyle.Flat;
            buttonUnggahJasa.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUnggahJasa.ForeColor = Color.White;
            buttonUnggahJasa.Location = new Point(36, 288);
            buttonUnggahJasa.Margin = new Padding(3, 2, 3, 2);
            buttonUnggahJasa.Name = "buttonUnggahJasa";
            buttonUnggahJasa.Size = new Size(139, 134);
            buttonUnggahJasa.TabIndex = 18;
            buttonUnggahJasa.Text = "Unggah Jasa";
            buttonUnggahJasa.UseVisualStyleBackColor = false;
            buttonUnggahJasa.Click += buttonUnggahJasa_Click;
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
            labelJudul.Text = "Menu Penjual";
            labelJudul.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 857);
            Controls.Add(buttonHapusJasa);
            Controls.Add(buttonUnggahJasa);
            Controls.Add(labelJudul);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            FormClosed += Form3_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHapusJasa;
        private Button buttonUnggahJasa;
        private Label labelJudul;
    }
}