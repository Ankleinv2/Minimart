using Guna.UI2.WinForms;
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
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace ManageMiniMart
{
    public delegate void ReloadFormProduct();
    public partial class FormProduct : Form
    {
        private CategoryService categoryService;
        private ProductService productService;
        private ProductDiscountService productDiscountService;

        public FormProduct(bool checkLoadFormProductEmployeeOrManager)              // true: Manager, false: Employee
        {
            InitializeComponent();
            categoryService = new CategoryService();
            productService = new ProductService();
            productDiscountService = new ProductDiscountService();

            cbbCategory.DataSource = categoryService.getCBBCategory();
            loadAllProduct();
            if (checkLoadFormProductEmployeeOrManager == false)
            {
                btnAdd.Visible = false;
                btnEdit.Visible = false;
                //btnDelete.Visible = false;
            }
        }
        // Load
        private void loadAllProduct()
        {

            dgvProduct.DataSource = null;
            dgvProduct.DataSource = productService.getAllProductView();
            dgvProduct.Refresh();



        }

        // cbbCategory
        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cateId = ((CBBItem)cbbCategory.SelectedItem).Value;
            string productName = txtProductName.Text;
            if(cateId > 0 )
            {
                dgvProduct.DataSource = productService.getListProductViewByProductNameAndCategory(cateId,productName);
            }
            else
            {
                dgvProduct.DataSource = productService.getListProductViewByProductName(productName);
            }
            
        }
        // btnSearch
        private void btnSearch_Click(object sender, EventArgs e)              //btnSearch_Click
        {
            int cID = ((CBBItem)cbbCategory.SelectedItem).Value;
            if(cID == 0)
            {
                dgvProduct.DataSource = productService.getListProductViewByProductName(txtProductName.Text);
            }
            else
            {
                dgvProduct.DataSource = productService.getListProductViewByProductNameAndCategory(cID,txtProductName.Text);
            }
            
        }

        // btnAdd
        private void btnAdd_Click(object sender, EventArgs e)              // btnAdd_Click
        {
            AddProductForm addproduct = new AddProductForm(loadAllProduct);
            addproduct.ShowDialog();
            loadAllProduct();
        }

        // btnEdit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = dgvProduct.SelectedRows[0].Cells[0].Value.ToString();

            Product product = productService.getProductById(Convert.ToInt16(id));
            AddProductForm addproduct = new AddProductForm(loadAllProduct);
            addproduct.editProduct(product);        // Đưa hết toàn bộ dữ liệu của product cho Form AddProduct
            addproduct.ShowDialog();
            loadAllProduct();

        }
        // btnDelete
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
