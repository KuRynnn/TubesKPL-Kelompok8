namespace TubesKPL_Kelompok8
{
    partial class Form4
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
            btnRegister = new Button();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxUsername = new TextBox();
            labelUsername = new Label();
            textBoxFullname = new TextBox();
            labelFullname = new Label();
            labelJudul = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightSeaGreen;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(36, 340);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(326, 34);
            btnRegister.TabIndex = 25;
            btnRegister.Text = "Daftar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(36, 284);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(326, 23);
            textBoxPassword.TabIndex = 24;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Arial", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.Location = new Point(37, 265);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(68, 16);
            labelPassword.TabIndex = 23;
            labelPassword.Text = "Password";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(36, 225);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(326, 23);
            textBoxEmail.TabIndex = 22;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Arial", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(36, 206);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(43, 16);
            labelEmail.TabIndex = 21;
            labelEmail.Text = "Email";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(36, 164);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(326, 23);
            textBoxUsername.TabIndex = 20;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Arial", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.Location = new Point(36, 145);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(71, 16);
            labelUsername.TabIndex = 19;
            labelUsername.Text = "Username";
            // 
            // textBoxFullname
            // 
            textBoxFullname.Location = new Point(36, 103);
            textBoxFullname.Name = "textBoxFullname";
            textBoxFullname.Size = new Size(326, 23);
            textBoxFullname.TabIndex = 18;
            // 
            // labelFullname
            // 
            labelFullname.AutoSize = true;
            labelFullname.Font = new Font("Arial", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            labelFullname.Location = new Point(36, 84);
            labelFullname.Name = "labelFullname";
            labelFullname.Size = new Size(67, 16);
            labelFullname.TabIndex = 17;
            labelFullname.Text = "Fullname";
            // 
            // labelJudul
            // 
            labelJudul.BackColor = Color.LightSeaGreen;
            labelJudul.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelJudul.ForeColor = Color.White;
            labelJudul.Location = new Point(-9, -3);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(414, 55);
            labelJudul.TabIndex = 16;
            labelJudul.Text = "Register";
            labelJudul.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 857);
            Controls.Add(btnRegister);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxUsername);
            Controls.Add(labelUsername);
            Controls.Add(textBoxFullname);
            Controls.Add(labelFullname);
            Controls.Add(labelJudul);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private TextBox textBoxFullname;
        private Label labelFullname;
        private Label labelJudul;
    }
}