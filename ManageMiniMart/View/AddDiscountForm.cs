using ManageMiniMart.BLL;
using ManageMiniMart.Custom;
using ManageMiniMart.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageMiniMart.View
{
    public partial class AddDiscountForm : Form
    {
        private DiscountService discountService;
        private ProductDiscountService productDiscountService;
        public AddDiscountForm()
        {
            InitializeComponent();
            discountService = new DiscountService();
            productDiscountService = new ProductDiscountService();
        }
        public void setDiscount(int discountId)
        {
            Discount discount = discountService.getDiscountById(discountId);
            txtDiscountName.Text = discount.discount_name;
            txtSale.Text = discount.sale.ToString();
            txtDiscountId.Text = discount.discount_id.ToString();
            dtpStartTime.Value = discount.start_time;
            dtpEndTime.Value = discount.end_time;
        }
        private void btnSave_Click(object sender, EventArgs e)          // -> OK
        {
            discountService.AddDiscountForm_Save(txtDiscountId.Text, txtDiscountName.Text, dtpStartTime.Value, dtpEndTime.Value, txtSale.Text);

            MyMessageBox messageBox = new MyMessageBox();
            messageBox.show("Save discount successful!!", "Notification");
            Dispose();

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
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