using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class AddSuppliers : Form
    {
        public AddSuppliers()
        {
            InitializeComponent();
        }
        public string conString = @"Data Source=DESKTOP-A8R15F7\SQLEXPRESS;Initial Catalog=POSDATABASE;Integrated Security=True";

        private void Reset()
        {
            SupplierName.Text = "";
            SupplierAddress.Text = "";
            SupplierPhone.Text = "";
            SupplierRemarks.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            if (SupplierName.Text == "" || SupplierAddress.Text == "" || SupplierPhone.Text == "" || SupplierRemarks.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand Sqlcmd = new SqlCommand("insert into SupplierTable(SupplierName,SupplierAddress,SupplierPhone,SupplierRemarks)values(@SNAME,@SADDRESS,@SPHONE,@SREMARKS)", con);
                    Sqlcmd.Parameters.AddWithValue("@SNAME", SupplierName.Text);
                    Sqlcmd.Parameters.AddWithValue("@SADDRESS", SupplierAddress.Text);
                    Sqlcmd.Parameters.AddWithValue("@SPHONE", SupplierPhone.Text);
                    Sqlcmd.Parameters.AddWithValue("@SREMARKS", SupplierRemarks.Text);
                    Sqlcmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Supplier Saved");
                    Reset();


                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void SupplierPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
