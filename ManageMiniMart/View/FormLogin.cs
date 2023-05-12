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
    {
       
        private bool check;                             // bỏ bool check
        private UserService userService;
        private EmployeeService employeeService;
        private ShiftDetailService shiftDetailService = new ShiftDetailService();
        public FormLogin(bool check = false)            // bỏ bool check
        {
            InitializeComponent();
            userService = new UserService();
            employeeService = new EmployeeService();
            this.check = check;
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
            string password = txtPassword.Text;
            Account account = userService.getAccount(userId,password);
            if (account != null)
            {
                if(account.role_id == 1)
                {
                    if (shiftDetailService.verifyTimeLogin(account.person_id))
                    {
                        DashboardEmployee employee = new DashboardEmployee(account, showAgain);        // Employee 
                        Hide();
                        employee.Show();
                    }
                    else throw new Exception($"Khong phai ca lam cua nhan vien {account.Person.person_name}");
                }
                else
                {
                    Dashboard dashboard = new Dashboard(account,showAgain);                   // Manager    ,closeForm
                    Hide();
                    dashboard.Show();
                    
                }
            }
            else
            {
                MyMessageBox messageBox = new MyMessageBox();
                messageBox.show("User id or password wrong! ");
            }
            txtPassword.Text = "";
            txtPassword.Focus();

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
        }
        private void closeForm()
        {
            Dispose();
        }



        // Cái đống này để bấm vào panelTitleBar để di chuyển Form 
        // Drag from
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int Param);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
         );
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //private void btn_Register_Click(object sender, EventArgs e)
        //{
        //    string personId = txtUserRegister.Text;
        //    string password = txtSignUpPassword.Text;
        //    string confirm = txtConfirmPassword.Text;
        //    // role: 1:Nhân viên; 2:Quản lí
        //    int role = 1;
        //    if(confirm.Equals(password) && password.Length > 4)
        //    {
        //        Account account = new Account
        //        {
        //            person_id= personId,
        //            password= password,
        //            role_id= role,
        //        };
        //        userService.SaveAccount(account);
        //        MyMessageBox myMessage = new MyMessageBox();
        //        myMessage.show("Add account successful");
        //    }
        //    else if(!confirm.Equals(password)) {
        //        //Form_Alert form_Alert = new Form_Alert();
        //        //form_Alert.showAlert("Confirm password wrong!", Form_Alert.enmType.error);
        //        MyMessageBox myMessage = new MyMessageBox();
        //        myMessage.show("Confirm password wrong!");

        //    }
        //    else if(password.Length < 4) {
        //        //Form_Alert form_Alert = new Form_Alert();
        //        //form_Alert.showAlert("Password should be greater 4 character", Form_Alert.enmType.error);
        //        MyMessageBox myMessage = new MyMessageBox();
        //        myMessage.show("Password should be greater 4 character");

        //    }
        //}
    }
}
