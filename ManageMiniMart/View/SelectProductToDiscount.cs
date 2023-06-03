using ManageMiniMart.BLL;
using ManageMiniMart.Custom;
using ManageMiniMart.DAL;
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
    public partial class SelectProductToDiscount : Form
    {
        public ProductDelegate productDelegate;
        private ProductService productService;
        private ProductDiscountService productDiscountService;
        private int discountId;
        public SelectProductToDiscount(int discountId =0)
        {
            InitializeComponent();
            productService = new ProductService();
            productDiscountService = new ProductDiscountService();
            loadAllProducts("");
            this.discountId = discountId;
        }

      
        public void loadAllProducts(string name)
        {
            dgvProduct.DataSource = productService.getListProductViewByProductName(name);
        }
        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduct.Columns[e.ColumnIndex].Name == "ADD")
            {
                int productId = Convert.ToInt32(dgvProduct.SelectedRows[0].Cells[0].Value.ToString());
                Product_Discount product_Discount = new Product_Discount
                {
                    discount_id = this.discountId,
                    product_id = productId
                };
                productDiscountService.saveProduct_Discount(product_Discount);
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadAllProducts(txtProductName.Text);
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
