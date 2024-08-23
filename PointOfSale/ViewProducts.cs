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
namespace PointOfSale
{
    public partial class ViewProducts : Form
    {
        public ViewProducts()
        {
            InitializeComponent();
            displayProducts();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        

        public void Reset()
        {
            ProductName.Text = "";
            ProductCategory.Text = "";
            ProductPrice.Text = "";
            ProductQuantity.Text = "";
            flag = 0;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A8R15F7\SQLEXPRESS;Initial Catalog=POSDATABASE;Integrated Security=True");
        public void displayProducts()
        {
            con.Open();
            string Query = "Select * from ProductTable";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ProductsDataGridView.DataSource = dt;
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                MessageBox.Show("Select The Product");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand Sqlcmd = new SqlCommand("delete from ProductTable where ProductID=@ProductKey", con);
                    Sqlcmd.Parameters.AddWithValue("@ProductKey", flag);

                    Sqlcmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product Deleted");
                    displayProducts();
                    Reset();


                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
        int flag = 0;
        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductsDataGridView.CurrentRow.Selected = true;

            DataGridViewRow row = this.ProductsDataGridView.Rows[e.RowIndex];


            ProductName.Text = ProductsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            ProductCategory.Text = ProductsDataGridView.Rows[e.RowIndex].Cells["ProductCategory"].Value.ToString();
            ProductPrice.Text = ProductsDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            ProductQuantity.Text = ProductsDataGridView.SelectedRows[0].Cells[4].Value.ToString();

            if (ProductName.Text == "")
            {
                flag = 0;
            }
            else
            {
                flag = Convert.ToInt32(ProductsDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ProductName.Text == "" || ProductCategory.SelectedIndex == -1 || ProductPrice.Text == "" || ProductQuantity.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand Sqlcmd = new SqlCommand("Update ProductTable set ProductName = @PNAME,ProductCategory = @PCATEGORY,ProductPrice = @PPRICE,ProductQuantity = @PQUANTITY where ProductID = @ProductKey", con);
                    Sqlcmd.Parameters.AddWithValue("@PNAME", ProductName.Text);
                    Sqlcmd.Parameters.AddWithValue("@PCATEGORY", ProductCategory.SelectedItem.ToString());
                    Sqlcmd.Parameters.AddWithValue("@PPRICE", ProductPrice.Text);
                    Sqlcmd.Parameters.AddWithValue("@PQUANTITY", ProductQuantity.Text);
                    Sqlcmd.Parameters.AddWithValue("@ProductKey", flag);
                    Sqlcmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product Updated");
                    displayProducts();
                    Reset();


                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
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
