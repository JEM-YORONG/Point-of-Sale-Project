using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Billing billing = new Billing();
            billing.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || Password.Text == "")
            {

                MessageBox.Show("Enter Username & Password");

            }
            else if (Username.Text == "Admin" && Password.Text == "Admin")
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password");
            }
        }

        private void exitlogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
