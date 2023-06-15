namespace TubesKPL_Kelompok8
{
    partial class UnggahJasa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonBack = new Button();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            labelDescription = new Label();
            textBoxPrice = new TextBox();
            labelPrice = new Label();
            textBoxServiceName = new TextBox();
            labelServiceName = new Label();
            labelJudul = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(22, 26);
            buttonBack.Margin = new Padding(6, 6, 6, 6);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(139, 49);
            buttonBack.TabIndex = 25;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSeaGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(22, 668);
            button3.Margin = new Padding(6, 4, 6, 4);
            button3.Name = "button3";
            button3.Size = new Size(605, 73);
            button3.TabIndex = 24;
            button3.Text = "Konfirmasi";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(59, 416);
            richTextBox1.Margin = new Padding(6, 6, 6, 6);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(557, 181);
            richTextBox1.TabIndex = 23;
            richTextBox1.Text = "";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDescription.Location = new Point(59, 378);
            labelDescription.Margin = new Padding(6, 0, 6, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(227, 29);
            labelDescription.TabIndex = 22;
            labelDescription.Text = "Enter Description: ";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(284, 294);
            textBoxPrice.Margin = new Padding(6, 6, 6, 6);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(333, 39);
            textBoxPrice.TabIndex = 21;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrice.Location = new Point(59, 301);
            labelPrice.Margin = new Padding(6, 0, 6, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(153, 29);
            labelPrice.TabIndex = 20;
            labelPrice.Text = "Enter Price: ";
            // 
            // textBoxServiceName
            // 
            textBoxServiceName.Location = new Point(284, 218);
            textBoxServiceName.Margin = new Padding(6, 6, 6, 6);
            textBoxServiceName.Name = "textBoxServiceName";
            textBoxServiceName.Size = new Size(333, 39);
            textBoxServiceName.TabIndex = 19;
            // 
            // labelServiceName
            // 
            labelServiceName.AutoSize = true;
            labelServiceName.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelServiceName.Location = new Point(59, 224);
            labelServiceName.Margin = new Padding(6, 0, 6, 0);
            labelServiceName.Name = "labelServiceName";
            labelServiceName.Size = new Size(250, 29);
            labelServiceName.TabIndex = 18;
            labelServiceName.Text = "Enter Service Name: ";
            // 
            // labelJudul
            // 
            labelJudul.BackColor = Color.LightSeaGreen;
            labelJudul.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelJudul.ForeColor = Color.White;
            labelJudul.Location = new Point(-17, -6);
            labelJudul.Margin = new Padding(6, 0, 6, 0);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(769, 117);
            labelJudul.TabIndex = 17;
            labelJudul.Text = "Unggah Jasa";
            labelJudul.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 26);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 1359);
            Controls.Add(buttonBack);
            Controls.Add(button3);
            Controls.Add(richTextBox1);
            Controls.Add(labelDescription);
            Controls.Add(textBoxPrice);
            Controls.Add(labelPrice);
            Controls.Add(textBoxServiceName);
            Controls.Add(labelServiceName);
            Controls.Add(labelJudul);
            Controls.Add(label1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private Button button3;
        private RichTextBox richTextBox1;
        private Label labelDescription;
        private TextBox textBoxPrice;
        private Label labelPrice;
        private TextBox textBoxServiceName;
        private Label labelServiceName;
        private Label labelJudul;
        private Label label1;
    }
}