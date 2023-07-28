namespace LoginSignUp
{
    partial class UserDataForm
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
            AccDGV = new DataGridView();
            username = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            EditDGV = new Button();
            SaveDGV = new Button();
            DeleteDGV = new Button();
            CancelDGV = new Button();
            ((System.ComponentModel.ISupportInitialize)AccDGV).BeginInit();
            SuspendLayout();
            // 
            // AccDGV
            // 
            AccDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AccDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccDGV.Columns.AddRange(new DataGridViewColumn[] { username, password });
            AccDGV.Location = new Point(51, 124);
            AccDGV.Margin = new Padding(2, 2, 2, 2);
            AccDGV.Name = "AccDGV";
            AccDGV.RowHeadersWidth = 62;
            AccDGV.RowTemplate.Height = 33;
            AccDGV.Size = new Size(435, 175);
            AccDGV.TabIndex = 0;
            // 
            // username
            // 
            username.HeaderText = "Username";
            username.MinimumWidth = 8;
            username.Name = "username";
            // 
            // password
            // 
            password.HeaderText = "Password";
            password.MinimumWidth = 8;
            password.Name = "password";
            // 
            // EditDGV
            // 
            EditDGV.BackColor = Color.LightSalmon;
            EditDGV.FlatStyle = FlatStyle.Popup;
            EditDGV.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            EditDGV.Location = new Point(374, 68);
            EditDGV.Margin = new Padding(2, 2, 2, 2);
            EditDGV.Name = "EditDGV";
            EditDGV.Size = new Size(78, 29);
            EditDGV.TabIndex = 1;
            EditDGV.Text = "Edit";
            EditDGV.UseVisualStyleBackColor = false;
            EditDGV.Click += EditDGV_Click;
            // 
            // SaveDGV
            // 
            SaveDGV.BackColor = Color.LightSalmon;
            SaveDGV.FlatStyle = FlatStyle.Popup;
            SaveDGV.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SaveDGV.Location = new Point(279, 68);
            SaveDGV.Margin = new Padding(2, 2, 2, 2);
            SaveDGV.Name = "SaveDGV";
            SaveDGV.Size = new Size(78, 29);
            SaveDGV.TabIndex = 2;
            SaveDGV.Text = "Save";
            SaveDGV.UseVisualStyleBackColor = false;
            // 
            // DeleteDGV
            // 
            DeleteDGV.BackColor = Color.LightSalmon;
            DeleteDGV.FlatStyle = FlatStyle.Popup;
            DeleteDGV.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteDGV.Location = new Point(185, 68);
            DeleteDGV.Margin = new Padding(2, 2, 2, 2);
            DeleteDGV.Name = "DeleteDGV";
            DeleteDGV.Size = new Size(78, 29);
            DeleteDGV.TabIndex = 3;
            DeleteDGV.Text = "Delete";
            DeleteDGV.UseVisualStyleBackColor = false;
            // 
            // CancelDGV
            // 
            CancelDGV.BackColor = Color.LightSalmon;
            CancelDGV.FlatStyle = FlatStyle.Popup;
            CancelDGV.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CancelDGV.Location = new Point(90, 68);
            CancelDGV.Margin = new Padding(2, 2, 2, 2);
            CancelDGV.Name = "CancelDGV";
            CancelDGV.Size = new Size(78, 29);
            CancelDGV.TabIndex = 4;
            CancelDGV.Text = "Cancel";
            CancelDGV.UseVisualStyleBackColor = false;
            // 
            // UserDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(542, 333);
            Controls.Add(CancelDGV);
            Controls.Add(DeleteDGV);
            Controls.Add(SaveDGV);
            Controls.Add(EditDGV);
            Controls.Add(AccDGV);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UserDataForm";
            Text = "UserData";
            Load += AccountDGV_Load;
            ((System.ComponentModel.ISupportInitialize)AccDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button EditDGV;
        private Button SaveDGV;
        private Button DeleteDGV;
        private Button CancelDGV;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn password;
        public DataGridView dataGridView1;
        public DataGridView AccDGV;
    }
}