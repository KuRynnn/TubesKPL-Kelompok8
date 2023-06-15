namespace TubesKPL_Kelompok8
{
    partial class Login
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
            labelJudul = new Label();
            labelPassword = new Label();
            labelUsername = new Label();
            buttonLogin = new Button();
            passwordTextBox = new RichTextBox();
            usernameTextBox = new RichTextBox();
            labelRegister = new Label();
            buttonRegister = new Button();
            SuspendLayout();
            // 
            // labelJudul
            // 
            labelJudul.BackColor = Color.LightSeaGreen;
            labelJudul.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelJudul.ForeColor = Color.White;
            labelJudul.Location = new Point(-4, -6);
            labelJudul.Margin = new Padding(6, 0, 6, 0);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(646, 117);
            labelJudul.TabIndex = 18;
            labelJudul.Text = "Login";
            labelJudul.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPassword
            // 
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(78, 354);
            labelPassword.Margin = new Padding(6, 0, 6, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(186, 49);
            labelPassword.TabIndex = 23;
            labelPassword.Text = "Password:";
            // 
            // labelUsername
            // 
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.Location = new Point(78, 183);
            labelUsername.Margin = new Padding(6, 0, 6, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(186, 49);
            labelUsername.TabIndex = 22;
            labelUsername.Text = "Username:";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.ButtonFace;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.Location = new Point(78, 610);
            buttonLogin.Margin = new Padding(6);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(472, 73);
            buttonLogin.TabIndex = 21;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(78, 410);
            passwordTextBox.Margin = new Padding(6);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(468, 68);
            passwordTextBox.TabIndex = 20;
            passwordTextBox.Text = "";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(78, 239);
            usernameTextBox.Margin = new Padding(6);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(468, 68);
            usernameTextBox.TabIndex = 19;
            usernameTextBox.Text = "";
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegister.Location = new Point(78, 758);
            labelRegister.Margin = new Padding(6, 0, 6, 0);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(363, 45);
            labelRegister.TabIndex = 24;
            labelRegister.Text = "Tidak mempunyai akun?";
            // 
            // buttonRegister
            // 
            buttonRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegister.Location = new Point(411, 833);
            buttonRegister.Margin = new Padding(6);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(139, 62);
            buttonRegister.TabIndex = 25;
            buttonRegister.Text = "Daftar";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 1359);
            Controls.Add(buttonRegister);
            Controls.Add(labelRegister);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(buttonLogin);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(labelJudul);
            Margin = new Padding(6);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelJudul;
        private Label labelPassword;
        private Label labelUsername;
        private Button buttonLogin;
        private RichTextBox passwordTextBox;
        private RichTextBox usernameTextBox;
        private Label labelRegister;
        private Button buttonRegister;
    }
}