using ManageMiniMart.BLL;
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
    public partial class FormCustomer : Form
    {
        private CustomerService customerService;
        public FormCustomer()
        {
            InitializeComponent();
            customerService = new CustomerService();
            loadAllCustomer();
        }
        // Load
        public void loadAllCustomer()
        {
            dgvCustomer.DataSource = null;
            dgvCustomer.DataSource = customerService.getAllCustomerView();
        }
        // btnAdd
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
            loadAllCustomer();
        }
        // btnEdit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string personId = dgvCustomer.SelectedRows[0].Cells[0].Value.ToString();
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.setEditForm(personId);                      // Lấy Customer và đưa lên trên AddCustomerForm
            addCustomerForm.ShowDialog();
            loadAllCustomer();

        }
        // btnSearch
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string customerName = txtSearch.Text;
            dgvCustomer.DataSource = customerService.getListCustomerViewByName(customerName);
        }
    }
}
