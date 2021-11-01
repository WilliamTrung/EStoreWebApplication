using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp.Admin.ProductManagement
{
    public partial class frmProductManagement : Form
    {
        IProductRepository pr = new ProductRepository();
        BindingSource source = new BindingSource();
        public frmProductManagement()
        {
            InitializeComponent();
        }
        private void LoadProduct()
        {
            var products = pr.GetListProducts();
            try
            {
                source.DataSource = products;
                txtCategoryId.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtProductId.DataBindings.Clear();

                txtCategoryId.DataBindings.Add("Text", source, "CategoryID");
                txtName.DataBindings.Add("Text", source, "ProductName");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtProductId.DataBindings.Add("Text", source, "ProductId");

                dgvMember.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void lbUnitsInStock_Click(object sender, EventArgs e)
        {

        }
    }
}
