using ManageMiniMart.BLL;
using ManageMiniMart.Custom;
using ManageMiniMart.DAL;
using ManageMiniMart.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Windows.Forms;

namespace ManageMiniMart.View
{
    public delegate void ProductDelegate(int productId, int amount);
    public delegate void CustomerDelegate(string customerId);
    public partial class FormPayment : Form
    {
        private ProductService productService;
        private DiscountService discountService;
        private CustomerService customerService;
        private BillService billService;
        private Bill_ProductService bill_ProductService;
        private List<ProductInBill> listProductInBill;

        private Account currentAccount;

        public FormPayment(Account account = null)
        {
            InitializeComponent();

            productService = new ProductService();
            discountService = new DiscountService();
            customerService = new CustomerService();
            billService = new BillService();
            bill_ProductService = new Bill_ProductService();
            listProductInBill = new List<ProductInBill>();

            this.currentAccount = account;
            cbbPayment.DataSource = getCBBMethodPay();
        }
        public List<string> getCBBMethodPay()
        {
            List<string> strings = new List<string>();
            strings.Add("Cash");
            strings.Add("Bank account");
            return strings;
        }
        public void loadProductInBill()
        {
            dgvProduct.DataSource = null;
            dgvProduct.DataSource = listProductInBill;
            dgvProduct.Refresh();
        }

        private void setCustomerId_Input(string customerId)
        {
            txtCustomerName.Text = customerService.getCustomerById(customerId).customer_name;
            txtCustomerID.Text = customerId;
            if (customerService.getCustomerPoint(customerId) != 0)
            {
                checkUsePoint.Visible = true;
                lblUsePoint.Visible = true;
                lblUsePoint.Text = "Use Point: "+customerService.getCustomerPoint(customerId).ToString() + " points";
            }
            else
            {
                checkUsePoint.Visible = false;
                lblUsePoint.Visible = false;
                showPoint.Text = "";
            }
        }
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            SelectCustomerForm selectCustomerForm = new SelectCustomerForm(setCustomerId_Input);
            selectCustomerForm.setCustomer(customerName);
            selectCustomerForm.ShowDialog();
            if(txtCustomerID.Text!="")
            btnRemoveCustomerSelect.Visible = true;
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string productName = txtProductId.Text;
            SelectProductForm selectProductForm = new SelectProductForm(AddProductInBill);
            selectProductForm.loadAllProducts(productName);
            selectProductForm.ShowDialog();
        }
        private void AddProductInBill(int productId, int amount)
        {
            billService.addProductInBill(listProductInBill, productId, amount);

            loadProductInBill();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MyMessageBox myMessage = new MyMessageBox();
            DialogResult rs = myMessage.show("Are you complete ?", "Confirm", MyMessageBox.TypeMessage.YESNO, MyMessageBox.TypeIcon.INFO);
            if (rs == DialogResult.Yes)
            {
                if (billService.saveBill(listProductInBill.Count, txtCustomerID.Text, currentAccount.person_id, cbbPayment.Text, DateTime.Now, listProductInBill, checkUsePoint.Checked))
                {
                    checkUsePoint.Checked = false;
                    setCustomerId_Input(txtCustomerID.Text);
                }
                listProductInBill.Clear();
                loadProductInBill();
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProduct.SelectedRows)
                {
                    listProductInBill.RemoveAt(row.Index);
                }
                loadProductInBill();
            }
        }

        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            checkUsePoint.Visible = false;
            checkUsePoint.Checked = false;
            lblUsePoint.Visible = false;
            showPoint.Text = "";
            btnRemoveCustomerSelect.Visible = false;
        }
    }
}
