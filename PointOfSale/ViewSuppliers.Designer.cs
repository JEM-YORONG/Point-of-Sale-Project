namespace PointOfSale
{
    partial class ViewSuppliers
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
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SupplierRemarks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SupplierPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SupplierAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SupplierName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SupplierDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(436, 409);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 60;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(307, 409);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 59;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(304, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 58;
            this.label5.Text = "REMARKS:";
            // 
            // SupplierRemarks
            // 
            this.SupplierRemarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.SupplierRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SupplierRemarks.ForeColor = System.Drawing.Color.White;
            this.SupplierRemarks.Location = new System.Drawing.Point(307, 334);
            this.SupplierRemarks.Multiline = true;
            this.SupplierRemarks.Name = "SupplierRemarks";
            this.SupplierRemarks.Size = new System.Drawing.Size(204, 69);
            this.SupplierRemarks.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(304, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 15);
            this.label4.TabIndex = 56;
            this.label4.Text = "SUPPLIER CONTACT NUMBER:";
            // 
            // SupplierPhone
            // 
            this.SupplierPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.SupplierPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SupplierPhone.ForeColor = System.Drawing.Color.White;
            this.SupplierPhone.Location = new System.Drawing.Point(307, 286);
            this.SupplierPhone.Name = "SupplierPhone";
            this.SupplierPhone.Size = new System.Drawing.Size(204, 20);
            this.SupplierPhone.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(304, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = "SUPPLIER ADDRESS:";
            // 
            // SupplierAddress
            // 
            this.SupplierAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.SupplierAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SupplierAddress.ForeColor = System.Drawing.Color.White;
            this.SupplierAddress.Location = new System.Drawing.Point(307, 198);
            this.SupplierAddress.Multiline = true;
            this.SupplierAddress.Name = "SupplierAddress";
            this.SupplierAddress.Size = new System.Drawing.Size(204, 69);
            this.SupplierAddress.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(304, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "SUPPLIER NAME:";
            // 
            // SupplierName
            // 
            this.SupplierName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.SupplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SupplierName.ForeColor = System.Drawing.Color.White;
            this.SupplierName.Location = new System.Drawing.Point(307, 151);
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.Size = new System.Drawing.Size(204, 20);
            this.SupplierName.TabIndex = 51;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(492, 23);
            this.button3.TabIndex = 61;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SupplierDataGridView
            // 
            this.SupplierDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.SupplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierDataGridView.Location = new System.Drawing.Point(12, 97);
            this.SupplierDataGridView.Name = "SupplierDataGridView";
            this.SupplierDataGridView.ReadOnly = true;
            this.SupplierDataGridView.Size = new System.Drawing.Size(286, 380);
            this.SupplierDataGridView.TabIndex = 62;
            this.SupplierDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplierDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 63;
            this.label1.Text = "SUPPLIERS LIST";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::PointOfSale.Properties.Resources.community;
            this.pictureBox1.Location = new System.Drawing.Point(256, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // ViewSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(529, 518);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SupplierDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SupplierRemarks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SupplierPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SupplierAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SupplierName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewSuppliers";
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SupplierRemarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SupplierPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SupplierAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SupplierName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView SupplierDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}