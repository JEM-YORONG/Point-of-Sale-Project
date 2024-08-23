namespace PointOfSale
{
    partial class ViewProducts
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
            this.ProductCategory = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductCategory
            // 
            this.ProductCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductCategory.ForeColor = System.Drawing.Color.White;
            this.ProductCategory.FormattingEnabled = true;
            this.ProductCategory.Items.AddRange(new object[] {
            "Cloths",
            "Pants",
            "Short"});
            this.ProductCategory.Location = new System.Drawing.Point(304, 226);
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.Size = new System.Drawing.Size(186, 21);
            this.ProductCategory.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(405, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(304, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "EDIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(301, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "PRODUCT QUANTITY:";
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ProductQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductQuantity.ForeColor = System.Drawing.Color.White;
            this.ProductQuantity.Location = new System.Drawing.Point(304, 326);
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.Size = new System.Drawing.Size(186, 20);
            this.ProductQuantity.TabIndex = 30;
            this.ProductQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductQuantity_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(301, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "PRODUCT PRICE:";
            // 
            // ProductPrice
            // 
            this.ProductPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductPrice.ForeColor = System.Drawing.Color.White;
            this.ProductPrice.Location = new System.Drawing.Point(304, 278);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(186, 20);
            this.ProductPrice.TabIndex = 28;
            this.ProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductPrice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(301, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "PRODUCT CATEGORY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(301, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "PRODUCT NAME:";
            // 
            // ProductName
            // 
            this.ProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductName.ForeColor = System.Drawing.Color.White;
            this.ProductName.Location = new System.Drawing.Point(304, 178);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(186, 20);
            this.ProductName.TabIndex = 25;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 474);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(478, 32);
            this.button3.TabIndex = 35;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Location = new System.Drawing.Point(12, 91);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.ReadOnly = true;
            this.ProductsDataGridView.Size = new System.Drawing.Size(286, 380);
            this.ProductsDataGridView.TabIndex = 51;
            this.ProductsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 52;
            this.label1.Text = "PRODUCTS LIST";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::PointOfSale.Properties.Resources.new_product;
            this.pictureBox1.Location = new System.Drawing.Point(238, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(502, 518);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductsDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ProductCategory);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewProducts";
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ProductCategory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}