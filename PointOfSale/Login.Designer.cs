namespace PointOfSale
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.exitlogin = new System.Windows.Forms.PictureBox();
            this.loginlogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(67, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Username:";
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(70, 138);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(176, 20);
            this.Username.TabIndex = 71;
            this.Username.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(67, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Password:";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(70, 185);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(176, 20);
            this.Password.TabIndex = 73;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(70, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 75;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(106, 257);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(102, 13);
            this.linkLabel1.TabIndex = 76;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Continue As Cashier";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // exitlogin
            // 
            this.exitlogin.Image = global::PointOfSale.Properties.Resources.logout;
            this.exitlogin.Location = new System.Drawing.Point(273, 12);
            this.exitlogin.Name = "exitlogin";
            this.exitlogin.Size = new System.Drawing.Size(19, 21);
            this.exitlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitlogin.TabIndex = 78;
            this.exitlogin.TabStop = false;
            this.exitlogin.Click += new System.EventHandler(this.exitlogin_Click);
            // 
            // loginlogo
            // 
            this.loginlogo.Enabled = false;
            this.loginlogo.Image = global::PointOfSale.Properties.Resources.login__1_;
            this.loginlogo.Location = new System.Drawing.Point(136, 46);
            this.loginlogo.Name = "loginlogo";
            this.loginlogo.Size = new System.Drawing.Size(52, 50);
            this.loginlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginlogo.TabIndex = 77;
            this.loginlogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(304, 315);
            this.Controls.Add(this.exitlogin);
            this.Controls.Add(this.loginlogo);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.exitlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox loginlogo;
        private System.Windows.Forms.PictureBox exitlogin;
    }
}