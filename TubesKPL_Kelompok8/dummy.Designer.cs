﻿namespace TubesKPL_Kelompok8
{
    partial class dummy
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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(204, 478);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(219, 47);
            button1.TabIndex = 1;
            button1.Text = "Back To Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dummy
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 1359);
            Controls.Add(button1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "dummy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dummy";
            Load += dummy_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}