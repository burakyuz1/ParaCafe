using ParaCafe.Data.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParaCafe
{
    public partial class ProductsForm : Form
    {
        private readonly CafeData db;
        private readonly BindingList<Product> products;

        public ProductsForm(CafeData db)
        {
            this.db = db;
            InitializeComponent();
            products = new BindingList<Product>(db.Products);
            dgvProducts.DataSource = products;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text.Trim();
            if (productName == "")
            {
                MessageBox.Show("Veri giriniz.");
                return;
            } 
            

            

            products.Add(new Product() { ProductName = productName, UnitPrice = nmuUnitPrice.Value });
            txtProductName.Clear();
            nmuUnitPrice.Value = 0;
        }
    }
}
