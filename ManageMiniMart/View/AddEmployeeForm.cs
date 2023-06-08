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

namespace ManageMiniMart.View
{
    public partial class AddEmployeeForm : Form
    {
        private EmployeeService employeeService;
        private UserService userService;
        private bool enable_edit_info=false;
        public AddEmployeeForm()
        {
            InitializeComponent();
            employeeService= new EmployeeService();
            userService= new UserService();
        }


        public void setEmployee(string employeeId)                  // Đưa employee lên để edit Employee and Manager (Dùng cho quản lý Employee)
        {
            Person person = employeeService.getEmployeeById(employeeId);
            if (person != null)
            {
                txtEmployeeId.Text = employeeId;
                txtEmployeeId.Enabled=false;
                txtEmployeeName.Text = person.person_name;
                dtpBirthdate.Value = person.birthdate.Value;
                txtAddress.Text = person.address;
                txtPhoneNumber.Text = person.phone_number;
                txtEmail.Text = person.email;
                txtSalary.Text = person.salary.ToString();
            }
        }
        public void setEditInfo(string employeeId)              // Dùng cho Edit infomation
        {
            Person person = employeeService.getEmployeeById(employeeId);
            if (person != null)
            {
                btnChangePassword.Visible = true;
                txtEmployeeId.Text= employeeId; txtEmployeeId.Enabled = false;

                txtEmployeeName.Text = person.person_name; txtEmployeeName.Enabled = false;
                dtpBirthdate.Value = person.birthdate.Value; dtpBirthdate.Enabled = false; 
                txtAddress.Text = person.address; txtAddress.Enabled = false;
                txtPhoneNumber.Text = person.phone_number; txtPhoneNumber.Enabled = false;
                txtEmail.Text = person.email; txtEmail.Enabled = false;
                txtSalary.Text = person.salary.ToString(); txtSalary.Enabled = false;

                lblPersonalInformation.Visible = true;
                panelEmployeeForm.Visible=false;
                btnSave.Visible=false;
                btnCancel.Visible = false;
                btnEdit.Visible=true;

            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtEmployeeName.Enabled = true;
            dtpBirthdate.Enabled = true;
            txtAddress.Enabled = true;
            txtPhoneNumber.Enabled = true;
            txtEmail.Enabled = true;

            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnEdit.Visible = false;
            enable_edit_info = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            employeeService.saveEmployee(txtEmployeeId.Enabled, txtEmployeeId.Text, txtEmployeeName.Text, dtpBirthdate.Value, txtAddress.Text, txtEmail.Text, txtSalary.Text, txtPhoneNumber.Text);
            MyMessageBox myMessage = new MyMessageBox();
            myMessage.show("Successful!");
            if (enable_edit_info == true)
            {
                this.Refresh();
                setEditInfo(txtEmployeeId.Text);
            }
            else
            {
                Dispose();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (enable_edit_info == true)
            {
                setEditInfo(txtEmployeeId.Text);
            }
            else
            {
                Dispose();
            }
            
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

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FormRegister f=new FormRegister();
            f.setInfoRegister(false,txtEmployeeId.Text);
            f.ShowDialog();
        }
    }
}
