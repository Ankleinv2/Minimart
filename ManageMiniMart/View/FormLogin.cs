using ManageMiniMart;
using ManageMiniMart.BLL;
using ManageMiniMart.Custom;
using ManageMiniMart.DAL;
using ManageMiniMart.View;
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

namespace Register_Login
{
    public delegate void ShowLogin();               // để mở lại FormLogin
    public partial class FormLogin : Form
    {                           // bỏ bool check
        private UserService userService;
        private EmployeeService employeeService;
        private ShiftDetailService shiftDetailService;
        private DiscountService discountService;
        private ProductDiscountService productDiscountService;
        public FormLogin()            // bỏ bool check
        {
            InitializeComponent();
            userService = new UserService();
            employeeService = new EmployeeService();
            discountService= new DiscountService();
            productDiscountService= new ProductDiscountService();
            shiftDetailService = new ShiftDetailService();
            discountService.autoDeleteDiscountWhenOutOfTime();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = txtUserId.Text;
            string password = userService.encryption(txtPassword.Text);
            txtPassword.Text = "";
            txtPassword.Focus();
            Account account = userService.getAccount(userId, password);
            if (account.role_id == 1)
            {
                if (shiftDetailService.verifyTimeLogin(account))
                {
                    DashboardEmployee employee = new DashboardEmployee(account, showAgain);        // Employee 
                    Hide();
                    employee.Show();
                }
            }
            else
            {
                Dashboard dashboard = new Dashboard(account, showAgain);                   // Manager,closeForm
                Hide();
                dashboard.Show();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter )
            {
                btnLogin_Click(sender, e);
                //txtUserId.Text = "";
            }
            
        }
        public void showAgain()
        {
            Show();
            txtUserId.Text = "";
            txtPassword.Text = "";
            txtUserId.Focus();
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

        private void showPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) txtPassword.PasswordChar = '\0';
        }

        private void showPassword_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) txtPassword.PasswordChar = '*';
        }
    }
}
