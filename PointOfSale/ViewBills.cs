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
    public partial class ViewBills : Form
    {
        public ViewBills()
        {
            InitializeComponent();
            displayBill();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A8R15F7\SQLEXPRESS;Initial Catalog=POSDATABASE;Integrated Security=True");
        public void displayBill()
        {
            con.Open();
            string Query = "Select * from BillTable";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BillingDataGridView.DataSource = dt;
            con.Close();
        }
        private void ViewBills_Load(object sender, EventArgs e)
        {

        }

        private void BillingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
