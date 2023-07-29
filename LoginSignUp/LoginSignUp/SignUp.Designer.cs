namespace LoginSignUp
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            SignUpLabel = new Label();
            pictureBox1 = new PictureBox();
            UserRegLbl = new Label();
            PassRegLbl = new Label();
            UserRegTxtBx = new TextBox();
            PassRegTxtBx = new TextBox();
            SignButtonUp = new Button();
            SUbackBTTN = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SignUpLabel
            // 
            SignUpLabel.AutoSize = true;
            SignUpLabel.Font = new Font("Consolas", 26F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpLabel.Location = new Point(95, 112);
            SignUpLabel.Name = "SignUpLabel";
            SignUpLabel.Size = new Size(230, 61);
            SignUpLabel.TabIndex = 0;
            SignUpLabel.Text = "Sign Up";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(95, 176);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 7);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // UserRegLbl
            // 
            UserRegLbl.AutoSize = true;
            UserRegLbl.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UserRegLbl.Location = new Point(138, 269);
            UserRegLbl.Name = "UserRegLbl";
            UserRegLbl.Size = new Size(120, 26);
            UserRegLbl.TabIndex = 2;
            UserRegLbl.Text = "Username:";
            // 
            // PassRegLbl
            // 
            PassRegLbl.AutoSize = true;
            PassRegLbl.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PassRegLbl.Location = new Point(138, 338);
            PassRegLbl.Name = "PassRegLbl";
            PassRegLbl.Size = new Size(120, 26);
            PassRegLbl.TabIndex = 3;
            PassRegLbl.Text = "Password:";
            // 
            // UserRegTxtBx
            // 
            UserRegTxtBx.BackColor = Color.AntiqueWhite;
            UserRegTxtBx.Location = new Point(264, 266);
            UserRegTxtBx.Name = "UserRegTxtBx";
            UserRegTxtBx.Size = new Size(411, 31);
            UserRegTxtBx.TabIndex = 4;
            // 
            // PassRegTxtBx
            // 
            PassRegTxtBx.BackColor = Color.AntiqueWhite;
            PassRegTxtBx.Location = new Point(264, 335);
            PassRegTxtBx.Name = "PassRegTxtBx";
            PassRegTxtBx.Size = new Size(411, 31);
            PassRegTxtBx.TabIndex = 5;
            // 
            // SignButtonUp
            // 
            SignButtonUp.BackColor = Color.LightSalmon;
            SignButtonUp.FlatStyle = FlatStyle.Popup;
            SignButtonUp.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SignButtonUp.Location = new Point(546, 394);
            SignButtonUp.Name = "SignButtonUp";
            SignButtonUp.Size = new Size(129, 45);
            SignButtonUp.TabIndex = 9;
            SignButtonUp.Text = "SIGN UP";
            SignButtonUp.UseVisualStyleBackColor = false;
            SignButtonUp.Click += SignButtonUp_Click;
            // 
            // SUbackBTTN
            // 
            SUbackBTTN.BackColor = Color.FromArgb(255, 224, 192);
            SUbackBTTN.FlatAppearance.BorderSize = 0;
            SUbackBTTN.FlatStyle = FlatStyle.Flat;
            SUbackBTTN.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SUbackBTTN.Image = (Image)resources.GetObject("SUbackBTTN.Image");
            SUbackBTTN.ImageAlign = ContentAlignment.MiddleLeft;
            SUbackBTTN.Location = new Point(95, 43);
            SUbackBTTN.Name = "SUbackBTTN";
            SUbackBTTN.Size = new Size(129, 45);
            SUbackBTTN.TabIndex = 10;
            SUbackBTTN.Text = "Back";
            SUbackBTTN.UseVisualStyleBackColor = false;
            SUbackBTTN.Click += SUbackBTTN_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 541);
            Controls.Add(SUbackBTTN);
            Controls.Add(SignButtonUp);
            Controls.Add(PassRegTxtBx);
            Controls.Add(UserRegTxtBx);
            Controls.Add(PassRegLbl);
            Controls.Add(UserRegLbl);
            Controls.Add(pictureBox1);
            Controls.Add(SignUpLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            Load += SignUpForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SignUpLabel;
        private PictureBox pictureBox1;
        private Button SignButtonUp;
        private Button SUbackBTTN;
        private Label UserRegLbl;
        private Label PassRegLbl;
        private TextBox UserRegTxtBx;
        private TextBox PassRegTxtBx;
    }
}