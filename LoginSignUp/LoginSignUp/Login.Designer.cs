namespace LoginSignUp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Title = new Label();
            UserIcon = new PictureBox();
            PasswordIcon = new PictureBox();
            UserLog = new TextBox();
            PasswordLog = new TextBox();
            UserColon = new Label();
            label1 = new Label();
            LoginButton = new Button();
            SignUpButton = new Button();
            ((System.ComponentModel.ISupportInitialize)UserIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PasswordIcon).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.FlatStyle = FlatStyle.Flat;
            Title.Font = new Font("Consolas", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(26, 93);
            Title.Name = "Title";
            Title.Size = new Size(599, 32);
            Title.TabIndex = 0;
            Title.Text = "Digital Product Sales Management System";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            Title.Click += label1_Click;
            // 
            // UserIcon
            // 
            UserIcon.BackgroundImage = (Image)resources.GetObject("UserIcon.BackgroundImage");
            UserIcon.BackgroundImageLayout = ImageLayout.Center;
            UserIcon.Location = new Point(215, 193);
            UserIcon.Margin = new Padding(3, 2, 3, 2);
            UserIcon.Name = "UserIcon";
            UserIcon.Size = new Size(59, 50);
            UserIcon.TabIndex = 1;
            UserIcon.TabStop = false;
            UserIcon.Click += UserIcon_Click;
            // 
            // PasswordIcon
            // 
            PasswordIcon.BackgroundImage = (Image)resources.GetObject("PasswordIcon.BackgroundImage");
            PasswordIcon.BackgroundImageLayout = ImageLayout.Center;
            PasswordIcon.Location = new Point(215, 248);
            PasswordIcon.Margin = new Padding(3, 2, 3, 2);
            PasswordIcon.Name = "PasswordIcon";
            PasswordIcon.Size = new Size(59, 50);
            PasswordIcon.TabIndex = 2;
            PasswordIcon.TabStop = false;
            PasswordIcon.Click += pictureBox1_Click;
            // 
            // UserLog
            // 
            UserLog.BackColor = Color.AntiqueWhite;
            UserLog.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserLog.Location = new Point(313, 201);
            UserLog.Margin = new Padding(3, 2, 3, 2);
            UserLog.Name = "UserLog";
            UserLog.PlaceholderText = "Username";
            UserLog.Size = new Size(379, 26);
            UserLog.TabIndex = 3;
            UserLog.Tag = "";
            UserLog.TextChanged += UserInputBox_TextChanged;
            // 
            // PasswordLog
            // 
            PasswordLog.BackColor = Color.AntiqueWhite;
            PasswordLog.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLog.Location = new Point(313, 256);
            PasswordLog.Margin = new Padding(3, 2, 3, 2);
            PasswordLog.Name = "PasswordLog";
            PasswordLog.PlaceholderText = "Password";
            PasswordLog.Size = new Size(379, 26);
            PasswordLog.TabIndex = 4;
            PasswordLog.Tag = "";
            PasswordLog.UseSystemPasswordChar = true;
            PasswordLog.TextChanged += PasswordInputBox_TextChanged;
            // 
            // UserColon
            // 
            UserColon.AutoSize = true;
            UserColon.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserColon.Location = new Point(270, 204);
            UserColon.Name = "UserColon";
            UserColon.Size = new Size(18, 19);
            UserColon.TabIndex = 5;
            UserColon.Text = ":";
            UserColon.Click += UserColon_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(270, 256);
            label1.Name = "label1";
            label1.Size = new Size(18, 19);
            label1.TabIndex = 6;
            label1.Text = ":";
            label1.Click += label1_Click_1;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.LightSalmon;
            LoginButton.FlatStyle = FlatStyle.Popup;
            LoginButton.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(563, 319);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(129, 45);
            LoginButton.TabIndex = 7;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.LightSalmon;
            SignUpButton.FlatStyle = FlatStyle.Popup;
            SignUpButton.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SignUpButton.Location = new Point(313, 319);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(129, 45);
            SignUpButton.TabIndex = 8;
            SignUpButton.Text = "SIGN UP";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(937, 532);
            Controls.Add(SignUpButton);
            Controls.Add(LoginButton);
            Controls.Add(label1);
            Controls.Add(UserColon);
            Controls.Add(PasswordLog);
            Controls.Add(UserLog);
            Controls.Add(PasswordIcon);
            Controls.Add(UserIcon);
            Controls.Add(Title);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(953, 571);
            MinimumSize = new Size(953, 571);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)UserIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)PasswordIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private PictureBox UserIcon;
        private PictureBox PasswordIcon;
        private TextBox UserLog;
        private TextBox PasswordLog;
        private Label UserColon;
        private Label label1;
        private Button LoginButton;
        private Button SignUpButton;
    }
}