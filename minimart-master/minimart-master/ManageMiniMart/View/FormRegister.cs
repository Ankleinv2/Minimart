using ManageMiniMart.BLL;
using ManageMiniMart.Custom;
using ManageMiniMart.DAL;
using ManageMiniMart.DTO;
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ManageMiniMart.View
{
    public partial class FormRegister : Form
    {
        RoleService roleService;
        UserService userService;
        Account currentAccount=null;
        public FormRegister()
        {
            InitializeComponent();
            roleService = new RoleService();
            userService = new UserService();
            setCBBRole();
        }
        public void setCBBRole()
        {
            cbbRole.DataSource = roleService.getCBBRole();
        }
        public void setInfoRegister(bool checkChangepasswordOrRegister,string employeeId)       // false: changePassword, true: Register
        {
            if(checkChangepasswordOrRegister == false)
            {
                lblRole.Visible = false;
                cbbRole.Visible = false;
                lblRegister.Text = "Change password";
                btnRegister.Text = "Save";
                currentAccount= userService.getAccountByPersonId(employeeId);
            }
            txtUserId.Text = employeeId;
            txtUserId.ReadOnly = true;

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string person_id = txtUserId.Text;
            string password=txtPassword.Text.Trim();
            string confirmPassword=txtConfirmPassword.Text.Trim();
            int role_id;
            if (currentAccount == null)
            {
                role_id = ((CBBItem)cbbRole.SelectedItem).Value;
            }
            else
            {
                role_id = currentAccount.role_id;
            }
            
            if (password.Length < 4)
            {
                MyMessageBox messageBox = new MyMessageBox();
                messageBox.show("Password length must >= 4", "Notification");
            }
            else if (password != confirmPassword)
            {
                MyMessageBox messageBox = new MyMessageBox();
                messageBox.show("Password and Confirm Password does not mach","Notification");
            }
            else
            {
                Account account= new Account();
                account.person_id = person_id;
                account.password = userService.encryption(password);
                account.role_id = role_id;
                userService.saveAccount(account);
                MyMessageBox messageBox = new MyMessageBox();
                messageBox.show("Successful", "Notification");
                Dispose();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
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
