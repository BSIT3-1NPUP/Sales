namespace Sales
{
    partial class createProduct
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
            this.title = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.typelbl = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.desclbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.type_txtbox = new System.Windows.Forms.TextBox();
            this.price_txtbox = new System.Windows.Forms.TextBox();
            this.quantity_txtbox = new System.Windows.Forms.TextBox();
            this.description_txtbox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(239, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(283, 39);
            this.title.TabIndex = 0;
            this.title.Text = "Create Products";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(48, 115);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(199, 31);
            this.namelbl.TabIndex = 1;
            this.namelbl.Text = "Product Name";
            this.namelbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // typelbl
            // 
            this.typelbl.AutoSize = true;
            this.typelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typelbl.Location = new System.Drawing.Point(48, 170);
            this.typelbl.Name = "typelbl";
            this.typelbl.Size = new System.Drawing.Size(188, 31);
            this.typelbl.TabIndex = 2;
            this.typelbl.Text = "Product Type";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.Location = new System.Drawing.Point(48, 218);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(81, 31);
            this.pricelbl.TabIndex = 3;
            this.pricelbl.Text = "Price";
            // 
            // desclbl
            // 
            this.desclbl.AutoSize = true;
            this.desclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desclbl.Location = new System.Drawing.Point(48, 317);
            this.desclbl.Name = "desclbl";
            this.desclbl.Size = new System.Drawing.Size(162, 31);
            this.desclbl.TabIndex = 4;
            this.desclbl.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quantity";
            // 
            // name_txtbox
            // 
            this.name_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txtbox.Location = new System.Drawing.Point(309, 115);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(396, 38);
            this.name_txtbox.TabIndex = 6;
            this.name_txtbox.TextChanged += new System.EventHandler(this.name_txtbox_TextChanged);
            // 
            // type_txtbox
            // 
            this.type_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_txtbox.Location = new System.Drawing.Point(309, 167);
            this.type_txtbox.Name = "type_txtbox";
            this.type_txtbox.Size = new System.Drawing.Size(396, 38);
            this.type_txtbox.TabIndex = 7;
            // 
            // price_txtbox
            // 
            this.price_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_txtbox.Location = new System.Drawing.Point(309, 215);
            this.price_txtbox.Name = "price_txtbox";
            this.price_txtbox.Size = new System.Drawing.Size(396, 38);
            this.price_txtbox.TabIndex = 8;
            // 
            // quantity_txtbox
            // 
            this.quantity_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_txtbox.Location = new System.Drawing.Point(309, 263);
            this.quantity_txtbox.Name = "quantity_txtbox";
            this.quantity_txtbox.Size = new System.Drawing.Size(396, 38);
            this.quantity_txtbox.TabIndex = 9;
            // 
            // description_txtbox
            // 
            this.description_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_txtbox.Location = new System.Drawing.Point(309, 314);
            this.description_txtbox.Name = "description_txtbox";
            this.description_txtbox.Size = new System.Drawing.Size(396, 38);
            this.description_txtbox.TabIndex = 10;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(322, 384);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(121, 42);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // createProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.description_txtbox);
            this.Controls.Add(this.quantity_txtbox);
            this.Controls.Add(this.price_txtbox);
            this.Controls.Add(this.type_txtbox);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desclbl);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.typelbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.title);
            this.Name = "createProduct";
            this.Text = "Create Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label typelbl;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label desclbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.TextBox type_txtbox;
        private System.Windows.Forms.TextBox price_txtbox;
        private System.Windows.Forms.TextBox quantity_txtbox;
        private System.Windows.Forms.TextBox description_txtbox;
        private System.Windows.Forms.Button addBtn;
    }
}