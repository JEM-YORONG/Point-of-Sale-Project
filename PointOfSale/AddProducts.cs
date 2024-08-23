using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PointOfSale
{
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }
        public string conString = @"Data Source=DESKTOP-A8R15F7\SQLEXPRESS;Initial Catalog=POSDATABASE;Integrated Security=True";
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void Reset()
        {
            ProductName.Text = "";
            ProductCategory.Text = "";
            ProductPrice.Text = "";
            ProductQuantity.Text = "";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveProduct();
        }

        private void SaveProduct()
        {
 
            SqlConnection con = new SqlConnection(conString);
           
            if (ProductName.Text =="" || ProductCategory.SelectedIndex == -1 || ProductPrice.Text == "" || ProductQuantity.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand Sqlcmd = new SqlCommand("insert into ProductTable(ProductName,ProductCategory,ProductPrice,ProductQuantity)values(@PNAME,@PCATEGORY,@PPRICE,@PQUANTITY)",con);
                    Sqlcmd.Parameters.AddWithValue("@PNAME",ProductName.Text);
                    Sqlcmd.Parameters.AddWithValue("@PCATEGORY", ProductCategory.SelectedItem.ToString());
                    Sqlcmd.Parameters.AddWithValue("@PPRICE", ProductPrice.Text);
                    Sqlcmd.Parameters.AddWithValue("@PQUANTITY", ProductQuantity.Text);
                    Sqlcmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product Saved");
                    Reset();


                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
        
        

        private void AddProducts_Load(object sender, EventArgs e)
        {
            
        }

        private void ProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void ProductQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
