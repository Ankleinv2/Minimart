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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ManageMiniMart.View
{
    public partial class AddCustomerForm : Form
    {
        private CustomerService customerService;
        public AddCustomerForm()
        {
            InitializeComponent();
            customerService= new CustomerService();
            
        }
        // Lấy Customer và đưa lên AddCustomerForm
        public void setEditForm(string personId)
        {
            Customer customer= customerService.getCustomerById(personId);
            txtCustomerId.Enabled = false;
            txtCustomerId.Text = personId;
            txtCustomerName.Text = customer.customer_name;
            txtAddress.Text = customer.address;
            txtEmail.Text = customer.email;
            dtpBirthdate.Value = customer.birthdate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            customerService.saveCustomer(txtCustomerId.Enabled, txtCustomerId.Text, txtCustomerName.Text, dtpBirthdate.Value, txtAddress.Text, txtEmail.Text);
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
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
