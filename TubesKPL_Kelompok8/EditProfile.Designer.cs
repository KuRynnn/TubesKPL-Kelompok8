namespace TubesKPL_Kelompok8
{
    partial class EditProfile
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
            label2 = new Label();
            currentPasswordTextBox = new RichTextBox();
            buttonSave = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            confirmPasswordTextBox = new RichTextBox();
            labelPassword = new Label();
            labelUsername = new Label();
            newPasswordTextBox = new RichTextBox();
            newUsernameTextBox = new RichTextBox();
            buttonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelJudul
            // 
            labelJudul.BackColor = Color.LightSeaGreen;
            labelJudul.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelJudul.ForeColor = Color.White;
            labelJudul.Location = new Point(-9, -3);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(364, 55);
            labelJudul.TabIndex = 18;
            labelJudul.Text = "Edit Profile";
            labelJudul.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 442);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 31;
            label2.Text = "Current Password:";
            // 
            // currentPasswordTextBox
            // 
            currentPasswordTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            currentPasswordTextBox.Location = new Point(46, 469);
            currentPasswordTextBox.Name = "currentPasswordTextBox";
            currentPasswordTextBox.Size = new Size(254, 34);
            currentPasswordTextBox.TabIndex = 30;
            currentPasswordTextBox.Text = "";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ButtonFace;
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(46, 535);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(254, 34);
            buttonSave.TabIndex = 29;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(125, 77);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 83);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 362);
            label1.Name = "label1";
            label1.Size = new Size(160, 23);
            label1.TabIndex = 27;
            label1.Text = "Confirm Password:";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPasswordTextBox.Location = new Point(46, 388);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(254, 34);
            confirmPasswordTextBox.TabIndex = 26;
            confirmPasswordTextBox.Text = "";
            // 
            // labelPassword
            // 
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(46, 282);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(148, 23);
            labelPassword.TabIndex = 25;
            labelPassword.Text = "Change Password:";
            // 
            // labelUsername
            // 
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.Location = new Point(46, 202);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(148, 23);
            labelUsername.TabIndex = 24;
            labelUsername.Text = "Change Username:";
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            newPasswordTextBox.Location = new Point(46, 309);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.Size = new Size(254, 34);
            newPasswordTextBox.TabIndex = 23;
            newPasswordTextBox.Text = "";
            // 
            // newUsernameTextBox
            // 
            newUsernameTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            newUsernameTextBox.Location = new Point(46, 228);
            newUsernameTextBox.Name = "newUsernameTextBox";
            newUsernameTextBox.Size = new Size(254, 34);
            newUsernameTextBox.TabIndex = 22;
            newUsernameTextBox.Text = "";
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(12, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 32;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 637);
            Controls.Add(buttonBack);
            Controls.Add(label2);
            Controls.Add(currentPasswordTextBox);
            Controls.Add(buttonSave);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(newPasswordTextBox);
            Controls.Add(newUsernameTextBox);
            Controls.Add(labelJudul);
            Name = "EditProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProfile";
            FormClosed += EditProfile_FormClosed;
            Load += EditProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelJudul;
        private Label label2;
        private RichTextBox currentPasswordTextBox;
        private Button buttonSave;
        private PictureBox pictureBox1;
        private Label label1;
        private RichTextBox confirmPasswordTextBox;
        private Label labelPassword;
        private Label labelUsername;
        private RichTextBox newPasswordTextBox;
        private RichTextBox newUsernameTextBox;
        private Button buttonBack;
    }
}