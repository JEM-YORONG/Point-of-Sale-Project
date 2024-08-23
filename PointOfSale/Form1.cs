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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Product_Click(object sender, EventArgs e)
        {
            AddProducts addProducts = new AddProducts();
            addProducts.Show();
            addProducts.TopMost = true;
        }

        private void Supplier_Click(object sender, EventArgs e)
        {
            AddSuppliers addSuppliers = new AddSuppliers();
            addSuppliers.Show();
            addSuppliers.TopMost = true;
        }


        private void vSupplier_Click(object sender, EventArgs e)
        {
            ViewSuppliers viewSuppliers = new ViewSuppliers();  
            viewSuppliers.Show();
            this.Hide();
        }

        private void vProduct_Click(object sender, EventArgs e)
        {
            ViewProducts viewProducts = new ViewProducts();
            viewProducts.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
