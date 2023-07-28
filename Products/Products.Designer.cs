namespace Sales
{
    partial class Products
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LOGOUT = new System.Windows.Forms.Button();
            this.products_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.testBtn = new System.Windows.Forms.Button();
            this.pSalesBtn = new System.Windows.Forms.Button();
            this.pUsersBtn = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.pOrdersBtn = new System.Windows.Forms.Button();
            this.pHomeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.products_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Digital Product Sales Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(595, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Welcome, User001";
            // 
            // LOGOUT
            // 
            this.LOGOUT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LOGOUT.Location = new System.Drawing.Point(701, 41);
            this.LOGOUT.Name = "LOGOUT";
            this.LOGOUT.Size = new System.Drawing.Size(75, 23);
            this.LOGOUT.TabIndex = 16;
            this.LOGOUT.Text = "LOGOUT";
            this.LOGOUT.UseVisualStyleBackColor = true;
            // 
            // products_dataGridView1
            // 
            this.products_dataGridView1.AllowUserToAddRows = false;
            this.products_dataGridView1.AllowUserToDeleteRows = false;
            this.products_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products_dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SKU,
            this.productName,
            this.productType,
            this.productPrice,
            this.productQuantity,
            this.productDescription,
            this.editBtn,
            this.deleteBtn});
            this.products_dataGridView1.Location = new System.Drawing.Point(22, 157);
            this.products_dataGridView1.Name = "products_dataGridView1";
            this.products_dataGridView1.ReadOnly = true;
            this.products_dataGridView1.Size = new System.Drawing.Size(673, 281);
            this.products_dataGridView1.TabIndex = 25;
            this.products_dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "SKU";
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            this.SKU.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SKU.Width = 50;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "product_name";
            this.productName.HeaderText = "Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // productType
            // 
            this.productType.DataPropertyName = "product_type";
            this.productType.HeaderText = "Type";
            this.productType.Name = "productType";
            this.productType.ReadOnly = true;
            // 
            // productPrice
            // 
            this.productPrice.DataPropertyName = "price";
            this.productPrice.HeaderText = "Price";
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            this.productPrice.Width = 50;
            // 
            // productQuantity
            // 
            this.productQuantity.DataPropertyName = "product_quantity";
            this.productQuantity.HeaderText = "Quantity";
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.ReadOnly = true;
            this.productQuantity.Width = 50;
            // 
            // productDescription
            // 
            this.productDescription.DataPropertyName = "description";
            this.productDescription.HeaderText = "Description";
            this.productDescription.Name = "productDescription";
            this.productDescription.ReadOnly = true;
            // 
            // editBtn
            // 
            this.editBtn.HeaderText = "Edit";
            this.editBtn.Name = "editBtn";
            this.editBtn.ReadOnly = true;
            this.editBtn.Text = "EDIT";
            this.editBtn.ToolTipText = "Edit";
            this.editBtn.UseColumnTextForButtonValue = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.HeaderText = "Delete";
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ReadOnly = true;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.ToolTipText = "Delete";
            this.deleteBtn.UseColumnTextForButtonValue = true;
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(713, 157);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 23);
            this.testBtn.TabIndex = 26;
            this.testBtn.Text = "ADD RECORD";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // pSalesBtn
            // 
            this.pSalesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pSalesBtn.Image = global::Sales.Properties.Resources.sales;
            this.pSalesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pSalesBtn.Location = new System.Drawing.Point(652, 90);
            this.pSalesBtn.Name = "pSalesBtn";
            this.pSalesBtn.Size = new System.Drawing.Size(124, 50);
            this.pSalesBtn.TabIndex = 24;
            this.pSalesBtn.Text = "Sales";
            this.pSalesBtn.UseVisualStyleBackColor = false;
            this.pSalesBtn.Click += new System.EventHandler(this.pSalesBtn_Click);
            // 
            // pUsersBtn
            // 
            this.pUsersBtn.Image = global::Sales.Properties.Resources.profile;
            this.pUsersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pUsersBtn.Location = new System.Drawing.Point(499, 90);
            this.pUsersBtn.Name = "pUsersBtn";
            this.pUsersBtn.Size = new System.Drawing.Size(124, 50);
            this.pUsersBtn.TabIndex = 23;
            this.pUsersBtn.Text = "Users";
            this.pUsersBtn.UseVisualStyleBackColor = true;
            // 
            // productsBtn
            // 
            this.productsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.productsBtn.Image = global::Sales.Properties.Resources.box;
            this.productsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsBtn.Location = new System.Drawing.Point(343, 90);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(124, 50);
            this.productsBtn.TabIndex = 22;
            this.productsBtn.Text = "Products";
            this.productsBtn.UseVisualStyleBackColor = false;
            // 
            // pOrdersBtn
            // 
            this.pOrdersBtn.Image = global::Sales.Properties.Resources.order__1_;
            this.pOrdersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pOrdersBtn.Location = new System.Drawing.Point(181, 89);
            this.pOrdersBtn.Name = "pOrdersBtn";
            this.pOrdersBtn.Size = new System.Drawing.Size(124, 50);
            this.pOrdersBtn.TabIndex = 21;
            this.pOrdersBtn.Text = "Orders";
            this.pOrdersBtn.UseVisualStyleBackColor = true;
            this.pOrdersBtn.Click += new System.EventHandler(this.pOrdersBtn_Click);
            // 
            // pHomeBtn
            // 
            this.pHomeBtn.Image = global::Sales.Properties.Resources.home;
            this.pHomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pHomeBtn.Location = new System.Drawing.Point(22, 90);
            this.pHomeBtn.Name = "pHomeBtn";
            this.pHomeBtn.Size = new System.Drawing.Size(124, 50);
            this.pHomeBtn.TabIndex = 20;
            this.pHomeBtn.Text = "Home";
            this.pHomeBtn.UseVisualStyleBackColor = true;
            this.pHomeBtn.Click += new System.EventHandler(this.pHomeBtn_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.products_dataGridView1);
            this.Controls.Add(this.pSalesBtn);
            this.Controls.Add(this.pUsersBtn);
            this.Controls.Add(this.productsBtn);
            this.Controls.Add(this.pOrdersBtn);
            this.Controls.Add(this.pHomeBtn);
            this.Controls.Add(this.LOGOUT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.products_dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LOGOUT;
        private System.Windows.Forms.Button pHomeBtn;
        private System.Windows.Forms.Button pOrdersBtn;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Button pUsersBtn;
        private System.Windows.Forms.Button pSalesBtn;
        private System.Windows.Forms.DataGridView products_dataGridView1;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productType;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescription;
        private System.Windows.Forms.DataGridViewButtonColumn editBtn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteBtn;
    }
}