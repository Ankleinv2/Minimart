using ManageMiniMart.BLL;
using ManageMiniMart.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageMiniMart.View
{
    public partial class AddDiscountProductsForm : Form
    {
        ProductService productService;
        public AddDiscountProductsForm()
        {
            InitializeComponent();
            productService = new ProductService();
            //dgvProducts.DataSource = productService.getAllProductView();
            //dgvProducts.Columns[0].DisplayIndex = 7;
            //dgvProducts.Columns["Sale"].Visible = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            
        }
    }
}
