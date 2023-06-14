using System.Resources;

namespace TubesKPL_Kelompok8
{
    partial class Pembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pembayaran));
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.LightSeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.LightSeaGreen;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(13, 22);
            button2.Name = "button2";
            button2.Size = new Size(42, 29);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSeaGreen;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-1, 0);
            label1.Name = "label1";
            label1.Size = new Size(400, 73);
            label1.TabIndex = 7;
            label1.Text = "Pembayaran";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(13, 138);
            button1.Name = "button1";
            button1.Size = new Size(371, 58);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 88);
            label2.Name = "label2";
            label2.Size = new Size(291, 27);
            label2.TabIndex = 10;
            label2.Text = "Pilih Metode Pembayaran";
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(12, 220);
            button3.Name = "button3";
            button3.Size = new Size(371, 58);
            button3.TabIndex = 11;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(12, 303);
            button4.Name = "button4";
            button4.Size = new Size(371, 58);
            button4.TabIndex = 12;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Location = new Point(12, 388);
            button5.Name = "button5";
            button5.Size = new Size(371, 58);
            button5.TabIndex = 13;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Location = new Point(12, 472);
            button6.Name = "button6";
            button6.Size = new Size(371, 58);
            button6.TabIndex = 14;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Location = new Point(13, 560);
            button7.Name = "button7";
            button7.Size = new Size(371, 58);
            button7.TabIndex = 15;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.BackColor = Color.LightSeaGreen;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(12, 716);
            button8.Name = "button8";
            button8.Size = new Size(372, 46);
            button8.TabIndex = 16;
            button8.Text = "Lanjutkan";
            button8.UseVisualStyleBackColor = false;
            // 
            // Pembayaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 849);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "Pembayaran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pembayaran";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label1;
        private Button button1;
        private Label label2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}