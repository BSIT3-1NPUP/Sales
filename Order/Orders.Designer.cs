namespace Orders_AppDev
{
    partial class Orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Create_btn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LOGOUT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Order_dataGridView = new System.Windows.Forms.DataGridView();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Order_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Create_btn
            // 
            this.Create_btn.BackColor = System.Drawing.Color.RosyBrown;
            this.Create_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_btn.Location = new System.Drawing.Point(659, 148);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(123, 30);
            this.Create_btn.TabIndex = 42;
            this.Create_btn.Text = "Create Order";
            this.Create_btn.UseVisualStyleBackColor = false;
            this.Create_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(24, 76);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 50);
            this.button6.TabIndex = 40;
            this.button6.Text = "Home";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gainsboro;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(659, 76);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 50);
            this.button7.TabIndex = 39;
            this.button7.Text = "Sales";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(504, 76);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 50);
            this.button8.TabIndex = 38;
            this.button8.Text = "Users";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(345, 76);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(124, 50);
            this.button9.TabIndex = 37;
            this.button9.Text = "Products";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(185, 76);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(124, 50);
            this.button10.TabIndex = 36;
            this.button10.Text = "Orders";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(601, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Welcome, User001";
            // 
            // LOGOUT
            // 
            this.LOGOUT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LOGOUT.Location = new System.Drawing.Point(707, 29);
            this.LOGOUT.Name = "LOGOUT";
            this.LOGOUT.Size = new System.Drawing.Size(75, 23);
            this.LOGOUT.TabIndex = 34;
            this.LOGOUT.Text = "LOGOUT";
            this.LOGOUT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Product Sales Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Order_dataGridView
            // 
            this.Order_dataGridView.AllowUserToAddRows = false;
            this.Order_dataGridView.AllowUserToDeleteRows = false;
            this.Order_dataGridView.AllowUserToResizeColumns = false;
            this.Order_dataGridView.AllowUserToResizeRows = false;
            this.Order_dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Order_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Order_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Order_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Order_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_id,
            this.customer_name,
            this.product_name,
            this.qty_order,
            this.total_amount,
            this.Edit,
            this.Delete});
            this.Order_dataGridView.Location = new System.Drawing.Point(24, 193);
            this.Order_dataGridView.Name = "Order_dataGridView";
            this.Order_dataGridView.RowHeadersVisible = false;
            this.Order_dataGridView.ShowCellErrors = false;
            this.Order_dataGridView.ShowEditingIcon = false;
            this.Order_dataGridView.Size = new System.Drawing.Size(758, 238);
            this.Order_dataGridView.TabIndex = 44;
            this.Order_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Order_dataGridView_CellClick);
            this.Order_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Order_dataGridView_CellContentClick);
            // 
            // order_id
            // 
            this.order_id.DataPropertyName = "order_id";
            this.order_id.Frozen = true;
            this.order_id.HeaderText = "Order ID";
            this.order_id.MinimumWidth = 100;
            this.order_id.Name = "order_id";
            this.order_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // customer_name
            // 
            this.customer_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.Frozen = true;
            this.customer_name.HeaderText = "Customer Name";
            this.customer_name.MinimumWidth = 100;
            this.customer_name.Name = "customer_name";
            this.customer_name.Width = 155;
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.Frozen = true;
            this.product_name.HeaderText = "Product";
            this.product_name.Name = "product_name";
            // 
            // qty_order
            // 
            this.qty_order.DataPropertyName = "qty";
            this.qty_order.Frozen = true;
            this.qty_order.HeaderText = "Quantity";
            this.qty_order.Name = "qty_order";
            // 
            // total_amount
            // 
            this.total_amount.DataPropertyName = "total";
            this.total_amount.Frozen = true;
            this.total_amount.HeaderText = "Total";
            this.total_amount.Name = "total_amount";
            // 
            // Edit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit.Frozen = true;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Frozen = true;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(24, 148);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(285, 30);
            this.txtSearch.TabIndex = 45;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(315, 148);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Order_dataGridView);
            this.Controls.Add(this.Create_btn);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LOGOUT);
            this.Controls.Add(this.label1);
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Orders_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Order_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Create_btn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LOGOUT;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView Order_dataGridView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_amount;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

