using ManageMiniMart.BLL;
using ManageMiniMart.Custom;
using Register_Login;
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
    public partial class FormEmployee : Form
    {
        private EmployeeService employeeService;
        private UserService userService;
        public FormEmployee()
        {
            InitializeComponent();
            employeeService= new EmployeeService();
            userService= new UserService();
            loadAllEmployee();
        }
        public void loadAllEmployee()
        {
            dgvEmloyee.DataSource = null;
            dgvEmloyee.DataSource = employeeService.getAllEmployeeView();
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();
            loadAllEmployee();
        }
        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            string personId = dgvEmloyee.SelectedRows[0].Cells[0].Value.ToString();
            AddEmployeeForm employeeForm = new AddEmployeeForm();
            employeeForm.setEmployee(personId);
            employeeForm.ShowDialog();
            loadAllEmployee();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string personId = dgvEmloyee.SelectedRows[0].Cells[0].Value.ToString();
            if (userService.checkUserExits(personId))
            {
                MyMessageBox myMessage = new MyMessageBox();
                myMessage.show("Employee already have account","Notification");
            }
            else
            {
                FormRegister formRegister = new FormRegister();
                formRegister.setInfoRegister(true,personId);
                formRegister.ShowDialog();  
            }
            loadAllEmployee();
        }
        // Search employee name
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name=txtSearch.Text.Trim();
            dgvEmloyee.DataSource=employeeService.getListEmployeeByNamePersonView(name);

        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (dgvEmloyee.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow row in dgvEmloyee.SelectedRows)
                {
                    userService.resetPassword(row.Cells[0].Value.ToString());
                    //throw new Exception("Something wrong in reset password");
                }
            }
            MyMessageBox myMessage = new MyMessageBox();
            myMessage.show("Reset password successfully","Notification");
        }
    }
}
