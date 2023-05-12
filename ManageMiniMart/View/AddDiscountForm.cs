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

namespace ManageMiniMart.View
{
    public partial class AddDiscountForm : Form
    {
        private DiscountService discountService;
        public AddDiscountForm()
        {
            InitializeComponent();
            discountService= new DiscountService();
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
            if (txtDiscountName.Text == "") throw new Exception("Discount name is not empty");
            if(DateTime.Compare(dtpStartTime.Value,dtpEndTime.Value) > 0) throw new Exception("End Time should be Greater Than or Equal to Start Time");
            try
            {
                Convert.ToInt32(txtSale.Text);
            }
            catch(Exception)
            {
                throw new Exception("Sale must be a number");
            }
            string discountName = txtDiscountName.Text;
            DateTime startTime = dtpStartTime.Value;                    // Bỏ ToUniversalTime() đi
            DateTime endTime = dtpEndTime.Value;
            int sale = Convert.ToInt32(txtSale.Text);
            
            if (txtDiscountId.Text!="")                     // Edit                     
            {
                int discountId = Convert.ToInt32(txtDiscountId.Text);
                Discount discount = new Discount
                {
                    discount_id = discountId,
                    discount_name = discountName,
                    start_time = startTime,
                    end_time = endTime,
                    sale = sale
                };
                discountService.saveDiscount(discount);
            }
            else                                        // Add
            {
                Discount discount = new Discount
                {
                    discount_name = discountName,
                    start_time = startTime,
                    end_time = endTime,
                    sale = sale
                };
                discountService.saveDiscount(discount);
            }
            MyMessageBox messageBox = new MyMessageBox();
            messageBox.show("Save discount successful!!","Notification");
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
