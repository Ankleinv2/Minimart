using ManageMiniMart.BLL;
using ManageMiniMart.Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageMiniMart.View
{
    public partial class SelectProductForm : Form
    {
        public ProductDelegate productDelegate;
        private ProductService productService;
        
        public SelectProductForm(ProductDelegate method)
        {
            InitializeComponent();
            productService = new ProductService();
            this.productDelegate = method;
        }
        public void loadAllProducts(string name)
        {
            dgvProduct.DataSource = productService.getListProductViewByProductName(name);
        }
        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduct.Columns[e.ColumnIndex].Name == "ADD")
            {
                CustomFormInput c = new CustomFormInput();
                string amount = c.show("Quantity", "Amount product");
                int amountProduct;
                if (amount == "") return;
                else if (Convert.ToInt32(amount) < 0)
                {
                    throw new Exception("Quantity can not be a negative number");
                }
                else
                {
                    amountProduct = Convert.ToInt32(amount);
                }
                int productId = Convert.ToInt32(dgvProduct.SelectedRows[0].Cells[0].Value.ToString());
                this.productDelegate(productId, amountProduct);    // truyền productId, amountProduct lại về AddProductInBill bên FormPayment
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }
        // Drag from
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int Param);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
