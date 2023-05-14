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
            if (txtCustomerId.Enabled == true && txtCustomerId.Text=="") throw new Exception("CustomerID cannot be empty");
            if (txtCustomerId.Enabled == true && customerService.checkCustomerID_Exist(txtCustomerId.Text)==true) throw new Exception("Customer ID cannot be the same as the existing Customer ID");
            string customerId = txtCustomerId.Text;
            if (txtCustomerName.Text == "") throw new Exception("Customer name cannot be empty");
            if (DateTime.Compare(dtpBirthdate.Value, DateTime.Now) > 0) throw new Exception("Birthdate shoule be Smaller Than or Equal to current date");
            string customerName = txtCustomerName.Text;
            DateTime birthDate  = dtpBirthdate.Value;
            DateTime createTime = DateTime.Now;
            int point = 0;
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            Customer customerOld = customerService.getCustomerById(customerId);             // lấy Customer    -> Để đưa createTime vào
            if (customerOld == null)                                                // Add Customer
            {
                Customer customer = new Customer
                {
                    customer_id = customerId,
                    customer_name = customerName,
                    birthdate = birthDate,
                    created_time = createTime,
                    address = address,
                    point = point,
                    email = email,
                };
                customerService.saveCustomer(customer);
                MyMessageBox myMessage = new MyMessageBox();
                myMessage.show("Add customer successful !", "Nofitication", MyMessageBox.TypeMessage.CONFIRM, MyMessageBox.TypeIcon.INFO);

            }
            else                                                                  // Edit Customer
            {   
                Customer customer = new Customer
                {
                    customer_id = customerId,
                    customer_name = customerName,
                    birthdate = birthDate,
                    created_time = customerOld.created_time,
                    address = address,
                    point = customerOld.point,
                    email = email,
                };
                customerService.saveCustomer(customer);
                MyMessageBox myMessage = new MyMessageBox();
                myMessage.show("Edit customer successful !", "Nofitication", MyMessageBox.TypeMessage.CONFIRM, MyMessageBox.TypeIcon.INFO);
            }

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
