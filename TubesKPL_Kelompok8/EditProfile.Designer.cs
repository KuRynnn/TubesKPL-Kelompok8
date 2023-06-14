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
            title = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 471);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 32;
            label2.Text = "Current Password:";
            // 
            // currentPasswordTextBox
            // 
            currentPasswordTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            currentPasswordTextBox.Location = new Point(44, 498);
            currentPasswordTextBox.Name = "currentPasswordTextBox";
            currentPasswordTextBox.Size = new Size(254, 34);
            currentPasswordTextBox.TabIndex = 31;
            currentPasswordTextBox.Text = "";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ButtonFace;
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(44, 564);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(254, 34);
            buttonSave.TabIndex = 30;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(123, 106);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 83);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 391);
            label1.Name = "label1";
            label1.Size = new Size(160, 23);
            label1.TabIndex = 28;
            label1.Text = "Confirm Password:";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPasswordTextBox.Location = new Point(44, 417);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(254, 34);
            confirmPasswordTextBox.TabIndex = 27;
            confirmPasswordTextBox.Text = "";
            // 
            // labelPassword
            // 
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(44, 311);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(148, 23);
            labelPassword.TabIndex = 26;
            labelPassword.Text = "Change Password:";
            // 
            // labelUsername
            // 
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.Location = new Point(44, 231);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(148, 23);
            labelUsername.TabIndex = 25;
            labelUsername.Text = "Change Username:";
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            newPasswordTextBox.Location = new Point(44, 338);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.Size = new Size(254, 34);
            newPasswordTextBox.TabIndex = 24;
            newPasswordTextBox.Text = "";
            // 
            // newUsernameTextBox
            // 
            newUsernameTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            newUsernameTextBox.Location = new Point(44, 257);
            newUsernameTextBox.Name = "newUsernameTextBox";
            newUsernameTextBox.Size = new Size(254, 34);
            newUsernameTextBox.TabIndex = 23;
            newUsernameTextBox.Text = "";
            // 
            // title
            // 
            title.BackColor = Color.LightSeaGreen;
            title.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            title.ForeColor = Color.White;
            title.Location = new Point(-3, 0);
            title.Name = "title";
            title.Size = new Size(350, 55);
            title.TabIndex = 22;
            title.Text = "Edit Profile";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 637);
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
            Controls.Add(title);
            Name = "EditProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProfile";
            FormClosed += EditProfile_FormClosed;
            Load += EditProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

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
        private Label title;
    }
}