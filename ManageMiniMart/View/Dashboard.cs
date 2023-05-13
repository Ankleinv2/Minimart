using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;
using FontAwesome.Sharp;
using ManageMiniMart.DAL;
using ManageMiniMart.View;
using Register_Login;

namespace ManageMiniMart
{
    public partial class Dashboard : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private Account currentAccount;

        private ShowLogin showLogin;
        //private CloseLogin closeLogin;                      // không cần CloseLogin       ,CloseLogin close = null

        //private bool checkReloadForm=false;
        public Dashboard(Account account = null,ShowLogin actionOnLogin = null)     // không cần CloseLogin
        {

            InitializeComponent();
            this.currentAccount = account;
            this.showLogin = actionOnLogin;
            //this.closeLogin= close;

            //this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 57);
            panelMenu.Controls.Add(leftBorderBtn);
            // Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered= true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            if (currentAccount != null)
            {
                setUser();
            }

        }
        //Structs
        private struct RBGColor
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color yellowCustom = Color.FromArgb(255, 212, 59);
            public static Color greenCustom = Color.FromArgb(91, 166, 65);
            public static Color orangeLight = Color.FromArgb(255, 152, 0);
            public static Color blueLight = Color.FromArgb(72, 220, 223, 1);
        }
        private void setUser()
        {
            lblUserName.Text = this.currentAccount.Person.person_name;
            lblUserRole.Text = "Role : " + this.currentAccount.Role.role_name;
        }
        // Method
        private void DisableButton()                    // Đổi các button quản lý thành bình thường
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void ActiveButton(object senderBtn, Color color)            // Kích hoạt button
        {
            if(senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign= ContentAlignment.MiddleRight;
                // left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Icon Current ChildForm
                iconCurentChildForm.IconChar= currentBtn.IconChar;
                iconCurentChildForm.IconColor= color;
                lblTitleChildForm.Text = currentBtn.Text;
                lblTitleChildForm.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblTitleChildForm.ForeColor = color;

            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm!= null) {
                currentChildForm.Dispose();
            }
            currentChildForm= childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = childForm.Text;
        }
        // button
        private void btnPayment_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGColor.color1);
            OpenChildForm(new FormPayment(currentAccount));
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGColor.color2);
            OpenChildForm(new FormProduct(true));
            
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGColor.color3);
            OpenChildForm(new FormBill());
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGColor.color4);
            OpenChildForm(new FormDiscount());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGColor.color5);
            OpenChildForm(new FormCustomer());
        }
        private void btnAnalyst_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGColor.yellowCustom);
            OpenChildForm(new FormAnalyst());
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGColor.greenCustom);
            OpenChildForm(new FormEmployee());
        }
        private void btnShiftWork_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGColor.orangeLight);
            OpenChildForm(new FormShiftWork(true));
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGColor.blueLight);
            AddEmployeeForm f = new AddEmployeeForm();
            f.setEditInfo(currentAccount.person_id);
            OpenChildForm(f);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGColor.color6);
            this.showLogin();
            Dispose();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurentChildForm.IconChar = IconChar.Home;
            iconCurentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }
        private void pictureBoxSuperMinimart2_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.closeLogin();
            //Dispose(); 
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Minimized;
        }
        private void btnMaximize_Click(object sender,EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                WindowState= FormWindowState.Normal;
            }
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

    }
}
