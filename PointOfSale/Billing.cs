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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            displayProducts();
            GetCustomer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            
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
            ProductDataGridView.DataSource = dt;
            con.Close();
        }

        public void searchProducts()
        {
            con.Open();
            string Query = "Select * from ProductTable where ProductName='" + SearchTb.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ProductDataGridView.DataSource = dt;
            con.Close();
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            searchProducts();
            SearchTb.Text = "";

        }

        private void RefreshBox_Click(object sender, EventArgs e)
        {
            displayProducts();
            SearchTb.Text = "";
        }
        int flag = 0;
        String ProductName;
        int ProductPrice, ProductStock;
        int x = 1, total = 0;

        private void UpdateQuantity()
        {
            int newQuantity = ProductStock - Convert.ToInt32(QuantityTb.Text);
            try
            {
                con.Open();
                SqlCommand Sqlcmd = new SqlCommand("Update ProductTable set ProductQuantity = @PQUANTITY where ProductID = @ProductKey", con);
                
                Sqlcmd.Parameters.AddWithValue("@PQUANTITY", newQuantity);
                Sqlcmd.Parameters.AddWithValue("@ProductKey", flag);
                Sqlcmd.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("Product Updated");
                displayProducts();
               // Reset();


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Reset()
        {
            ProductName = "";
            QuantityTb.Text = "";
            VATTb.Text = "";
            DiscountTb.Text = "";
            flag = 0;
        }
        private void GetCustomer()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select CustomerID from CustomerTable", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustomerID",typeof(int));
            dt.Load(dr);
            CustomerIDBox.ValueMember = "CustomerID";
            CustomerIDBox.DataSource = dt;
            con.Close();
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (flag ==0)
            {
                MessageBox.Show("Select A Product");
            }else if (QuantityTb.Text=="")
            {
                MessageBox.Show("Enter Quantity");
            }
            else if (Convert.ToInt32(QuantityTb.Text) > ProductStock)
            {
                MessageBox.Show("No Enough Stock");
            }
            else
            {
                int SubTotal = Convert.ToInt32(QuantityTb.Text) * ProductPrice;
                total = total + SubTotal;
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(BillingDataGridView);
                dataGridViewRow.Cells[0].Value = x;
                dataGridViewRow.Cells[1].Value = ProductName;
                dataGridViewRow.Cells[2].Value = QuantityTb.Text;
                dataGridViewRow.Cells[3].Value = ProductPrice;
                dataGridViewRow.Cells[4].Value = SubTotal;

                BillingDataGridView.Rows.Add(dataGridViewRow);
                x++;
                SubTotalTb.Text = ""+total;
                UpdateQuantity();
                Reset();
            }
        }

        private void VATTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (VATTb.Text == "")
            {

            }else if (SubTotalTb.Text == "")
            {
                MessageBox.Show("Please Add Products To Cart");
                VATTb.Text = "";
            }
            else
            {
                try
                {
                    double VAT = (Convert.ToDouble(VATTb.Text) / 100 * Convert.ToInt32(SubTotalTb.Text));
                    TotalTaxTb.Text = "" + VAT;
                    TotalTB.Text = ""+(Convert.ToInt32(SubTotalTb.Text) + Convert.ToDouble(TotalTaxTb.Text));
                    
                }
                catch (Exception r)
                {
                    MessageBox.Show(r.Message);
                }
            }

           
        }
        private void InsertBill()
        {
            if (CustomerIDBox.SelectedIndex == -1 || PaymentMethod.SelectedIndex == -1 || TotalTB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand Sqlcmd = new SqlCommand("insert into BillTable(BillDate,CustomerID,CustomerName,PaymentMethod,Amount)values(@BILLDATE,@BCUSTOMERID,@BCUSTOMERNAME,@BPAYMENTMETHOD,@BAMOUNT)", con);
                    Sqlcmd.Parameters.AddWithValue("@BILLDATE", BillDate.Value.Date);
                    Sqlcmd.Parameters.AddWithValue("@BCUSTOMERID", CustomerIDBox.SelectedValue.ToString());
                    Sqlcmd.Parameters.AddWithValue("@BCUSTOMERNAME", CustomerName.Text);
                    Sqlcmd.Parameters.AddWithValue("@BPAYMENTMETHOD", PaymentMethod.SelectedItem.ToString());
                    Sqlcmd.Parameters.AddWithValue("@BAMOUNT", Convert.ToDouble(TotalTB.Text));
                    Sqlcmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Bill Saved");
                    displayProducts();
                    Reset();


                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (DiscountTb.Text == "")
            {

            }
            else if (SubTotalTb.Text == "")
            {
                MessageBox.Show("Please Add Products To Cart");
                DiscountTb.Text = "";
            }
            else
            {
                try
                {
                    double Discount = (Convert.ToDouble(DiscountTb.Text) / 100 * Convert.ToInt32(SubTotalTb.Text));
                    DiscountTaxTb.Text = "" + Discount;
                    TotalTB.Text = "" + (Convert.ToInt32(SubTotalTb.Text) + Convert.ToDouble(TotalTaxTb.Text) - Convert.ToDouble(DiscountTaxTb.Text));

                }
                catch (Exception r)
                {
                    MessageBox.Show(r.Message);
                }
            }
        }
        
        private void PrintBtn_Click(object sender, EventArgs e)
        {
            InsertBill();
            if (true) {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                    Reset();
                }
            }
            
            
            

        }
        int prodid, prodprices, prodquantity, totals, pos = 60;

        private void VATTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void DiscountTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void VATTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuantityTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch !=46)
            {
                e.Handled = true;
            }
        }

       

        private void vCustomer_Click(object sender, EventArgs e)
        {
            ViewBills viewBills = new ViewBills();
            viewBills.Show();
        }

       
        string productnames;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("RESIBOOOOO", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID PRODUCT QUANTITY PRICE SUBTOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(26, 40));

            foreach (DataGridViewRow row in BillingDataGridView.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                productnames = "" + row.Cells["Column2"].Value;
                prodprices = Convert.ToInt32(row.Cells["Column3"].Value);
                prodquantity = Convert.ToInt32(row.Cells["Column4"].Value);
                totals = Convert.ToInt32(row.Cells["Column5"].Value);

                e.Graphics.DrawString(" " + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(26, pos));
                e.Graphics.DrawString(" " + productnames, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(45, pos));
                e.Graphics.DrawString(" " + prodprices, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(120, pos));
                e.Graphics.DrawString(" " + prodquantity, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(170, pos));
                e.Graphics.DrawString(" " + totals, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(235, pos));
                pos = pos + 20;

            }

            e.Graphics.DrawString("GRAND TOTAL: " + TotalTB.Text, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(50, pos + 50));

            BillingDataGridView.Rows.Clear();
            BillingDataGridView.Refresh();
            pos = 100;
            TotalTB.Text = "";
            x = 0;

        }

        
        
        private void CustomerIDBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductDataGridView.CurrentRow.Selected = true;

            DataGridViewRow row = this.ProductDataGridView.Rows[e.RowIndex];
            ProductName = ProductDataGridView.SelectedRows[0].Cells[1].Value.ToString();  
            ProductPrice =Convert.ToInt32(ProductDataGridView.SelectedRows[0].Cells[3].Value.ToString());
            ProductStock = Convert.ToInt32(ProductDataGridView.SelectedRows[0].Cells[4].Value.ToString());

            if (ProductName == "")
            {
                flag = 0;
            }
            else
            {
                flag = Convert.ToInt32(ProductDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
