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

        void checkValidInformation()
        {
            if (txtProductName.Text == "") throw new Exception("Name product is not empty");
            if (txtBrand.Text == "") throw new Exception("Brand is not empty");
            try
            {

                Convert.ToInt32(txtPrice.Text);
                Convert.ToInt32(txtQuantity.Text);

            }
            catch (FormatException)
            {
                throw new Exception("Price and Quantity must be a number");
            }
            if (Convert.ToInt32(txtPrice.Text) < 0) throw new Exception("Price can not be a negative number");
            if (Convert.ToInt32(txtQuantity.Text) < 0) throw new Exception("Quantity can not be a negative number");
            if (cbbCategory.SelectedItem == null) throw new Exception("Catogory is not selected");

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
            checkValidInformation();
            string productId = txtProductId.Text;
            int discount_id = ((CBBItem)cbbDiscount.SelectedItem).Value;
            if (discount_id > 0 && productId=="")                               // add, có discount
            {
                Discount discount = discountService.getDiscountById(discount_id);
                List<Discount> discounts = new List<Discount>();
                discounts.Add(discount);
                Product product1 = new Product
                {
                    product_name = txtProductName.Text,
                    category_id = ((CBBItem)cbbCategory.SelectedItem).Value,
                    brand = txtBrand.Text,
                    price = Convert.ToDouble(txtPrice.Text),
                    quantity = Convert.ToInt16(txtQuantity.Text),            
                };
                productService.saveProduct(product1);
                Product_Discount product_Discount = new Product_Discount
                {
                    product_id = product1.product_id,
                    discount_id = discount_id,
                }; 
                productDiscountService.saveProduct_Discount(product_Discount);
            }
            else if(discount_id > 0 && productId != "")                     // edit , có discount
            {
                Product product2 = new Product
                {
                    product_id = Convert.ToInt32(productId),
                    product_name = txtProductName.Text,
                    price = Convert.ToDouble(txtPrice.Text),
                    brand = txtBrand.Text,
                    quantity = Convert.ToInt16(txtQuantity.Text),
                    category_id = ((CBBItem)cbbCategory.SelectedItem).Value,
                };
                productService.saveProduct(product2);
                // xoá discount cũ
                Product_Discount product_Discount1 = productDiscountService.getProduct_DiscountByProductIdAndDiscountId(product2.product_id, discountBefore);
                productDiscountService.deleteProduct_Discount(product_Discount1);
                // thêm discount mới
                Product_Discount product_Discount = new Product_Discount
                {
                    product_id = product2.product_id,
                    discount_id = discount_id,
                };
                productDiscountService.saveProduct_Discount(product_Discount);
            }
            else if(discount_id == 0 && productId != "")                // edit, không có discount
            {
                Product product = new Product
                {
                    product_id = Convert.ToInt32(productId),
                    product_name = txtProductName.Text,
                    price = Convert.ToDouble(txtPrice.Text),
                    brand = txtBrand.Text,
                    quantity = Convert.ToInt16(txtQuantity.Text),
                    category_id = ((CBBItem)cbbCategory.SelectedItem).Value,

                };
                //
                productService.saveProduct(product);
                //
                Product_Discount product_Discount1 = productDiscountService.getProduct_DiscountByProductIdAndDiscountId(product.product_id, discountBefore);
                productDiscountService.deleteProduct_Discount(product_Discount1);
            }
            else                           // add khong co discount
            {
                Product product = new Product
                {
                    product_name = txtProductName.Text,
                    price = Convert.ToDouble(txtPrice.Text),
                    brand = txtBrand.Text,
                    quantity = Convert.ToInt16(txtQuantity.Text),
                    category_id = ((CBBItem)cbbCategory.SelectedItem).Value
                };

                productService.saveProduct(product);
            }
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
