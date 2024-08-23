namespace PointOfSale
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.BillingDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SubTotalTb = new System.Windows.Forms.TextBox();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.vBills = new System.Windows.Forms.Button();
            this.CustomerIDBox = new System.Windows.Forms.ComboBox();
            this.BillDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RefreshBox = new System.Windows.Forms.PictureBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PaymentMethod = new System.Windows.Forms.ComboBox();
            this.TotalTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DiscountTaxTb = new System.Windows.Forms.TextBox();
            this.DiscountTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalTaxTb = new System.Windows.Forms.TextBox();
            this.VATTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QuantityTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BillingDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BillingDataGridView
            // 
            this.BillingDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BillingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BillingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.BillingDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BillingDataGridView.Location = new System.Drawing.Point(9, 281);
            this.BillingDataGridView.Name = "BillingDataGridView";
            this.BillingDataGridView.ReadOnly = true;
            this.BillingDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BillingDataGridView.Size = new System.Drawing.Size(398, 220);
            this.BillingDataGridView.TabIndex = 96;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SubTotal";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // BackBtn
            // 
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(716, 483);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 95;
            this.BackBtn.Text = "BACK";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.FlatAppearance.BorderSize = 0;
            this.PrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.ForeColor = System.Drawing.Color.White;
            this.PrintBtn.Location = new System.Drawing.Point(716, 390);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(75, 23);
            this.PrintBtn.TabIndex = 93;
            this.PrintBtn.Text = "PRINT";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 92;
            this.label4.Text = "SUB TOTAL:";
            // 
            // SubTotalTb
            // 
            this.SubTotalTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.SubTotalTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubTotalTb.Enabled = false;
            this.SubTotalTb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalTb.ForeColor = System.Drawing.Color.White;
            this.SubTotalTb.Location = new System.Drawing.Point(103, 5);
            this.SubTotalTb.Name = "SubTotalTb";
            this.SubTotalTb.Size = new System.Drawing.Size(184, 20);
            this.SubTotalTb.TabIndex = 91;
            // 
            // SearchTb
            // 
            this.SearchTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.SearchTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTb.ForeColor = System.Drawing.Color.White;
            this.SearchTb.Location = new System.Drawing.Point(6, 26);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(234, 20);
            this.SearchTb.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 88;
            this.label2.Text = "Customer Name:";
            // 
            // CustomerName
            // 
            this.CustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.ForeColor = System.Drawing.Color.White;
            this.CustomerName.Location = new System.Drawing.Point(13, 194);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CustomerName.Size = new System.Drawing.Size(176, 20);
            this.CustomerName.TabIndex = 87;
            // 
            // vBills
            // 
            this.vBills.FlatAppearance.BorderSize = 0;
            this.vBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vBills.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vBills.ForeColor = System.Drawing.Color.White;
            this.vBills.Location = new System.Drawing.Point(716, 12);
            this.vBills.Name = "vBills";
            this.vBills.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vBills.Size = new System.Drawing.Size(72, 58);
            this.vBills.TabIndex = 86;
            this.vBills.Text = "VIEW BILLS";
            this.vBills.UseVisualStyleBackColor = true;
            this.vBills.Click += new System.EventHandler(this.vCustomer_Click);
            // 
            // CustomerIDBox
            // 
            this.CustomerIDBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CustomerIDBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDBox.ForeColor = System.Drawing.Color.White;
            this.CustomerIDBox.FormattingEnabled = true;
            this.CustomerIDBox.Location = new System.Drawing.Point(14, 149);
            this.CustomerIDBox.Name = "CustomerIDBox";
            this.CustomerIDBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CustomerIDBox.Size = new System.Drawing.Size(175, 20);
            this.CustomerIDBox.TabIndex = 97;
            this.CustomerIDBox.Text = "Customer ID";
            this.CustomerIDBox.SelectionChangeCommitted += new System.EventHandler(this.CustomerIDBox_SelectionChangeCommitted);
            // 
            // BillDate
            // 
            this.BillDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BillDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BillDate.CalendarTitleForeColor = System.Drawing.Color.White;
            this.BillDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BillDate.Location = new System.Drawing.Point(13, 220);
            this.BillDate.Name = "BillDate";
            this.BillDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BillDate.Size = new System.Drawing.Size(175, 20);
            this.BillDate.TabIndex = 99;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Location = new System.Drawing.Point(319, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 43);
            this.panel1.TabIndex = 100;
            // 
            // AddBtn
            // 
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(3, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(80, 35);
            this.AddBtn.TabIndex = 101;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RefreshBox);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.SearchTb);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(416, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(357, 55);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Product Name";
            // 
            // RefreshBox
            // 
            this.RefreshBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RefreshBox.Image = global::PointOfSale.Properties.Resources.reloads;
            this.RefreshBox.Location = new System.Drawing.Point(322, 25);
            this.RefreshBox.Name = "RefreshBox";
            this.RefreshBox.Size = new System.Drawing.Size(29, 21);
            this.RefreshBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RefreshBox.TabIndex = 103;
            this.RefreshBox.TabStop = false;
            this.RefreshBox.Click += new System.EventHandler(this.RefreshBox_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(246, 25);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 102;
            this.SearchBtn.Text = "SEARCH";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ProductDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Location = new System.Drawing.Point(416, 151);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.ReadOnly = true;
            this.ProductDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProductDataGridView.Size = new System.Drawing.Size(357, 233);
            this.ProductDataGridView.TabIndex = 102;
            this.ProductDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataGridView_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PaymentMethod);
            this.panel2.Controls.Add(this.TotalTB);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.DiscountTaxTb);
            this.panel2.Controls.Add(this.DiscountTb);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TotalTaxTb);
            this.panel2.Controls.Add(this.VATTb);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.SubTotalTb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(416, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 116);
            this.panel2.TabIndex = 103;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.PaymentMethod.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethod.ForeColor = System.Drawing.Color.White;
            this.PaymentMethod.FormattingEnabled = true;
            this.PaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Debit Card"});
            this.PaymentMethod.Location = new System.Drawing.Point(165, 91);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PaymentMethod.Size = new System.Drawing.Size(122, 20);
            this.PaymentMethod.TabIndex = 105;
            this.PaymentMethod.Text = "Payment Method";
            // 
            // TotalTB
            // 
            this.TotalTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TotalTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalTB.Enabled = false;
            this.TotalTB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTB.ForeColor = System.Drawing.Color.White;
            this.TotalTB.Location = new System.Drawing.Point(103, 90);
            this.TotalTB.Name = "TotalTB";
            this.TotalTB.Size = new System.Drawing.Size(56, 20);
            this.TotalTB.TabIndex = 102;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 101;
            this.label8.Text = "TOTAL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(181, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 15);
            this.label7.TabIndex = 100;
            this.label7.Text = "%";
            // 
            // DiscountTaxTb
            // 
            this.DiscountTaxTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.DiscountTaxTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiscountTaxTb.Enabled = false;
            this.DiscountTaxTb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountTaxTb.ForeColor = System.Drawing.Color.White;
            this.DiscountTaxTb.Location = new System.Drawing.Point(205, 60);
            this.DiscountTaxTb.Name = "DiscountTaxTb";
            this.DiscountTaxTb.Size = new System.Drawing.Size(82, 20);
            this.DiscountTaxTb.TabIndex = 99;
            // 
            // DiscountTb
            // 
            this.DiscountTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.DiscountTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiscountTb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountTb.ForeColor = System.Drawing.Color.White;
            this.DiscountTb.Location = new System.Drawing.Point(103, 63);
            this.DiscountTb.Name = "DiscountTb";
            this.DiscountTb.Size = new System.Drawing.Size(72, 20);
            this.DiscountTb.TabIndex = 98;
            this.DiscountTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DiscountTb_KeyPress);
            this.DiscountTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 97;
            this.label6.Text = "DISCOUNT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(181, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 96;
            this.label5.Text = "%";
            // 
            // TotalTaxTb
            // 
            this.TotalTaxTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TotalTaxTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalTaxTb.Enabled = false;
            this.TotalTaxTb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTaxTb.ForeColor = System.Drawing.Color.White;
            this.TotalTaxTb.Location = new System.Drawing.Point(205, 31);
            this.TotalTaxTb.Name = "TotalTaxTb";
            this.TotalTaxTb.Size = new System.Drawing.Size(82, 20);
            this.TotalTaxTb.TabIndex = 95;
            // 
            // VATTb
            // 
            this.VATTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.VATTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VATTb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VATTb.ForeColor = System.Drawing.Color.White;
            this.VATTb.Location = new System.Drawing.Point(103, 31);
            this.VATTb.Name = "VATTb";
            this.VATTb.Size = new System.Drawing.Size(72, 20);
            this.VATTb.TabIndex = 94;
            this.VATTb.TextChanged += new System.EventHandler(this.VATTb_TextChanged);
            this.VATTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VATTb_KeyPress);
            this.VATTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VATTb_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 93;
            this.label1.Text = "VAT+ST:";
            // 
            // QuantityTb
            // 
            this.QuantityTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.QuantityTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityTb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTb.ForeColor = System.Drawing.Color.White;
            this.QuantityTb.Location = new System.Drawing.Point(80, 255);
            this.QuantityTb.Name = "QuantityTb";
            this.QuantityTb.Size = new System.Drawing.Size(109, 20);
            this.QuantityTb.TabIndex = 105;
            this.QuantityTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityTb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 106;
            this.label3.Text = "Quantity:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(95, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 61);
            this.label9.TabIndex = 107;
            this.label9.Text = "BILLING";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::PointOfSale.Properties.Resources.shopping_cart__1_;
            this.pictureBox1.Location = new System.Drawing.Point(169, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QuantityTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ProductDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BillDate);
            this.Controls.Add(this.CustomerIDBox);
            this.Controls.Add(this.BillingDataGridView);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.vBills);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)(this.BillingDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BillingDataGridView;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SubTotalTb;
        private System.Windows.Forms.TextBox SearchTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Button vBills;
        private System.Windows.Forms.ComboBox CustomerIDBox;
        private System.Windows.Forms.DateTimePicker BillDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox PaymentMethod;
        private System.Windows.Forms.TextBox TotalTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DiscountTaxTb;
        private System.Windows.Forms.TextBox DiscountTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TotalTaxTb;
        private System.Windows.Forms.TextBox VATTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox RefreshBox;
        private System.Windows.Forms.TextBox QuantityTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}