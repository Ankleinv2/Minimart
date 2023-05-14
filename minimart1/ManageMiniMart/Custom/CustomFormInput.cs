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

namespace ManageMiniMart.Custom
{
    public partial class CustomFormInput : Form
    {
        public CustomFormInput()
        {
            InitializeComponent();
        }
        public DialogResult dialog
        {
            get; set;
        }
        // result = 0 => Cancel || = 1 => Yes
        public enum TypeMessage
        {
            CONFIRM = 1,
            YESNO = 2
        }
        public enum TypeIcon
        {
            INFO = 1,
            WARNING = 2,
            QUESTION = 3
        }

        public void show(string message)
        {
            lblText.Text = message;
            ShowDialog();
        }
        public string show(string message, string title)
        {
            lblText.Text = message;
            lblTitle.Text = title;
            this.ShowDialog();
            return txtInput.Text;
        }
        public void show(string message, string title, TypeMessage typeMessage)
        {
            lblText.Text = message;
            lblTitle.Text = title;
            if (typeMessage == TypeMessage.CONFIRM)
            {

            }
            else if (typeMessage == TypeMessage.YESNO)
            {
                btnOK.Visible = false;
            }
            this.ShowDialog();
        }
        public DialogResult show(string message, string title, TypeMessage typeMessage, TypeIcon icon)
        {
            lblText.Text = message;
            lblTitle.Text = title;
            if (typeMessage == TypeMessage.CONFIRM)
            {

            }
            else if (typeMessage == TypeMessage.YESNO)
            {
                btnOK.Visible = false;
            }
            if (icon == TypeIcon.QUESTION)
            {
                //pictureBox1.Image = Image.FromFile(@"H:\OneDrive - The University of Technology\PBL3\image\icon\icons8_short_hair_lady_question_mark.ico");
            }
            if (icon == TypeIcon.WARNING)
            {
                //pictureBox1.Image = Image.FromFile(@"H:\OneDrive - The University of Technology\PBL3\image\icon\icons8_automatic_gearbox_warning.ico");
            }
            if (icon == TypeIcon.INFO)
            {
                //pictureBox1.Image = Image.FromFile(@"H:\OneDrive - The University of Technology\PBL3\image\icon\icons8_information_64.png");
            }
            this.ShowDialog();
            return dialog;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            dialog = DialogResult.Yes;
            Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dialog = DialogResult.No;
            Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.btnOK_Click(sender, e);
            }
        }
    }
}
