using ManageMiniMart.BLL;
using ManageMiniMart.Custom;
using ManageMiniMart.DAL;
using ManageMiniMart.DTO;
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

namespace ManageMiniMart
{
    public partial class AddProductForm : Form
    {
        public ReloadFormProduct formProduct;
        private CategoryService categoryService;
        private DiscountService discountService;
        private ProductService productService;
        private ProductDiscountService productDiscountService;
        private ExceptionHandlingService exceptionHandlingService;

        private int discountBefore;
        public AddProductForm(ReloadFormProduct formProduct)
        {
            InitializeComponent();
            categoryService = new CategoryService();
            discountService = new DiscountService();
            productService = new ProductService();
            productDiscountService = new ProductDiscountService();
            exceptionHandlingService = new ExceptionHandlingService();

            cbbCategory.DataSource = categoryService.getCBBCategory(true);
            cbbCategory.SelectedIndex = -1;
            cbbDiscount.DataSource = discountService.getCBBDiscount();
            
            this.formProduct = formProduct;

            lblProductID.Visible = false;
            panelProductID.Visible = false;
        }
        public void editProduct(Product product)                    // Đưa product lên addproductForm                    
        {
            lblProductID.Visible = true;
            panelProductID.Visible = true;
            txtProductId.Text = product.product_id.ToString();
            txtProductName.Text = product.product_name.ToString();
            txtBrand.Text = product.brand.ToString();
            txtPrice.Text = product.price.ToString();
            txtQuantity.Text = product.quantity.ToString();
            cbbCategory.Text = product.Category.category_name;
            
            string discountName = "";
            foreach(var discount in product.Product_Discount)
            {
                discountName += discount.Discount.discount_name;
            }
            cbbDiscount.Text = discountName;
            discountBefore = ((CBBItem)cbbDiscount.SelectedItem).Value;       
        }
        // Add or Update
        private void btnSave_Click(object sender, EventArgs e)
        {
            int discount_id = cbbCategory.SelectedItem == null ? 0 : ((CBBItem)cbbCategory.SelectedItem).Value;
            productService.saveProduct(txtProductId.Text, txtProductName.Text, txtBrand.Text, txtPrice.Text, txtQuantity.Text, discountBefore, ((CBBItem)cbbDiscount.SelectedItem).Value, discount_id);
            MyMessageBox messageBox = new MyMessageBox();
            messageBox.show("Successful","Notification");
            this.formProduct();
            Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
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

        // Cái đống này để bấm vào panelTitleBar để di chuyển Form 
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
