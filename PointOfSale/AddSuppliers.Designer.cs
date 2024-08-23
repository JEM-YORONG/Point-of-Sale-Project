namespace PointOfSale
{
    partial class AddSuppliers
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
            this.SupplierName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SupplierAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SupplierPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SupplierRemarks = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD SUPPLIER";
            // 
            // SupplierName
            // 
            this.SupplierName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.SupplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SupplierName.ForeColor = System.Drawing.Color.White;
            this.SupplierName.Location = new System.Drawing.Point(33, 100);
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.Size = new System.Drawing.Size(204, 20);
            this.SupplierName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "SUPPLIER NAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "SUPPLIER ADDRESS:";
            // 
            // SupplierAddress
            // 
            this.SupplierAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.SupplierAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SupplierAddress.ForeColor = System.Drawing.Color.White;
            this.SupplierAddress.Location = new System.Drawing.Point(33, 147);
            this.SupplierAddress.Multiline = true;
            this.SupplierAddress.Name = "SupplierAddress";
            this.SupplierAddress.Size = new System.Drawing.Size(204, 69);
            this.SupplierAddress.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "SUPPLIER CONTACT NUMBER:";
            // 
            // SupplierPhone
            // 
            this.SupplierPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.SupplierPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SupplierPhone.ForeColor = System.Drawing.Color.White;
            this.SupplierPhone.Location = new System.Drawing.Point(33, 235);
            this.SupplierPhone.Name = "SupplierPhone";
            this.SupplierPhone.Size = new System.Drawing.Size(204, 20);
            this.SupplierPhone.TabIndex = 5;
            this.SupplierPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SupplierPhone_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "REMARKS:";
            // 
            // SupplierRemarks
            // 
            this.SupplierRemarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.SupplierRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SupplierRemarks.ForeColor = System.Drawing.Color.White;
            this.SupplierRemarks.Location = new System.Drawing.Point(33, 283);
            this.SupplierRemarks.Multiline = true;
            this.SupplierRemarks.Name = "SupplierRemarks";
            this.SupplierRemarks.Size = new System.Drawing.Size(204, 69);
            this.SupplierRemarks.TabIndex = 7;
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(33, 366);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 9;
            this.SaveBtn.Text = "SAVE";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.FlatAppearance.BorderSize = 0;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(162, 366);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 10;
            this.ResetBtn.Text = "RESET";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(244, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(17, 30);
            this.button3.TabIndex = 11;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::PointOfSale.Properties.Resources.partner;
            this.pictureBox1.Location = new System.Drawing.Point(117, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // AddSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(273, 401);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SupplierRemarks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SupplierPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SupplierAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SupplierName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSuppliers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SupplierName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SupplierAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SupplierPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SupplierRemarks;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}