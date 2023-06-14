namespace TubesKPL_Kelompok8
{
    partial class Form1
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
            labelPassword = new Label();
            labelUsername = new Label();
            buttonLogin = new Button();
            passwordTextBox = new RichTextBox();
            usernameTextBox = new RichTextBox();
            title = new Label();
            SuspendLayout();
            // 
            // labelPassword
            // 
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(46, 225);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(100, 23);
            labelPassword.TabIndex = 16;
            labelPassword.Text = "Password:";
            // 
            // labelUsername
            // 
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.Location = new Point(46, 145);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(100, 23);
            labelUsername.TabIndex = 15;
            labelUsername.Text = "Username:";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.ButtonFace;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.Location = new Point(46, 345);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(254, 34);
            buttonLogin.TabIndex = 14;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(46, 251);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(254, 34);
            passwordTextBox.TabIndex = 13;
            passwordTextBox.Text = "";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(46, 171);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(254, 34);
            usernameTextBox.TabIndex = 12;
            usernameTextBox.Text = "";
            // 
            // title
            // 
            title.BackColor = Color.LightSeaGreen;
            title.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            title.ForeColor = Color.White;
            title.Location = new Point(-2, 0);
            title.Name = "title";
            title.Size = new Size(350, 55);
            title.TabIndex = 11;
            title.Text = "Log In";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 637);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(buttonLogin);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(title);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Label labelPassword;
        private Label labelUsername;
        private Button buttonLogin;
        private RichTextBox passwordTextBox;
        private RichTextBox usernameTextBox;
        private Label title;
    }
}