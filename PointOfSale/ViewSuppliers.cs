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
    public partial class ViewSuppliers : Form
    {
        public ViewSuppliers()
        {
            InitializeComponent();
            displaySupplier();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A8R15F7\SQLEXPRESS;Initial Catalog=POSDATABASE;Integrated Security=True");
        public void displaySupplier()
        {
            con.Open();
            string Query = "Select * from SupplierTable";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            SupplierDataGridView.DataSource = dt;
            con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
        int flag = 0;
        private void SupplierDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SupplierDataGridView.CurrentRow.Selected = true;

            DataGridViewRow row = this.SupplierDataGridView.Rows[e.RowIndex];



            SupplierName.Text = SupplierDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            SupplierAddress.Text = SupplierDataGridView.Rows[e.RowIndex].Cells["SupplierAddress"].Value.ToString();
            SupplierPhone.Text = SupplierDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            SupplierRemarks.Text = SupplierDataGridView.SelectedRows[0].Cells[4].Value.ToString();

            if (SupplierName.Text == "")
            {
                flag = 0;
            }
            else
            {
                flag = Convert.ToInt32(SupplierDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            }

        }
        public void Reset()
        {
            SupplierName.Text = "";
            SupplierAddress.Text = "";
            SupplierPhone.Text = "";
            SupplierRemarks.Text = "";
            flag = 0;
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                MessageBox.Show("Select The Supplier");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand Sqlcmd = new SqlCommand("delete from SupplierTable where SupplierID=@SupplierKey", con);
                    Sqlcmd.Parameters.AddWithValue("@SupplierKey", flag);

                    Sqlcmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Supplier Deleted");
                    displaySupplier();
                    Reset();


                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (SupplierName.Text == "" || SupplierAddress.Text == "" || SupplierPhone.Text == "" || SupplierRemarks.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand Sqlcmd = new SqlCommand("Update SupplierTable set SupplierName = @SNAME,SupplierAddress = @SADDRESS,SupplierPhone = @SPHONE,SupplierRemarks =@SREMARKS where SupplierID=@SupplierKey", con);
                    Sqlcmd.Parameters.AddWithValue("@SNAME", SupplierName.Text);
                    Sqlcmd.Parameters.AddWithValue("@SADDRESS", SupplierAddress.Text);
                    Sqlcmd.Parameters.AddWithValue("@SPHONE", SupplierPhone.Text);
                    Sqlcmd.Parameters.AddWithValue("@SREMARKS", SupplierRemarks.Text);
                    Sqlcmd.Parameters.AddWithValue("@SupplierKey", flag);
                    Sqlcmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Supplier Updated");
                    displaySupplier();
                    Reset();


                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            }
    }
}
