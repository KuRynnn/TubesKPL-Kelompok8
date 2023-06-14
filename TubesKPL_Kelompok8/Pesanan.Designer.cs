namespace TubesKPL_Kelompok8
{
    partial class Pesanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesanan));
            button2 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.LightSeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.LightSeaGreen;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(10, 22);
            button2.Name = "button2";
            button2.Size = new Size(42, 29);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSeaGreen;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-4, 0);
            label1.Name = "label1";
            label1.Size = new Size(400, 73);
            label1.TabIndex = 5;
            label1.Text = "Pesanan";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkGray;
            pictureBox1.Location = new Point(10, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(372, 268);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Pesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 849);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "Pesanan";
            Text = "Pesanan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}