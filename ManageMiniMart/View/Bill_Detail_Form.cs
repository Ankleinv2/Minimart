using ManageMiniMart.BLL;
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
    public partial class Bill_Detail_Form : Form
    {
        private Bill_ProductService bill_ProductService;
        private BillService billService;
        private ProductService productService;
        public Bill_Detail_Form()
        {
            InitializeComponent();
            billService = new BillService();
            bill_ProductService=new Bill_ProductService();
            productService=new ProductService();


        }
        public void setDatagridView(int billId)
        {
            Bill bill = billService.getBillById(billId);
            lblBill_id.Text = bill.bill_id.ToString();
            lblBillDate.Text = bill.created_time.ToString("dd/MM/yyyy hh:mm:ss");
            if (bill.Customer != null)
            {
                lblCustomerName.Text = bill.Customer.customer_name;
            }
            else
            {
                lblCustomerName.Text = "";
            }
            lblEmployeeName.Text = bill.Person.person_name;
            lblPaymentMethod.Text = bill.payment_method;



            List<Bill_Product> getAllProductInBill = bill_ProductService.getBill_ProductByBillId(billId);
            List<BillDetailView> billDetails = new List<BillDetailView>();

            double totalBeforeDiscount = 0;
            double TotalMoneyBeforeDiscount = 0;
            double TotalPayAfterDiscount = 0;
            double totalDiscount = 0;
            foreach (Bill_Product bill_Product in getAllProductInBill)
            {
                totalBeforeDiscount = bill_Product.quantity * bill_Product.Product.price;
                TotalMoneyBeforeDiscount+=totalBeforeDiscount;

                TotalPayAfterDiscount += bill_Product.quantity * bill_Product.price;
                BillDetailView details = new BillDetailView
                {
                    Product_id = bill_Product.Product.product_id,
                    Product_name = bill_Product.Product.product_name,
                    Price = Double.Parse(bill_Product.Product.price.ToString()).ToString("#,## VNĐ").Replace(',', '.'),
                    Quantity = bill_Product.quantity,
                    Total = Double.Parse(totalBeforeDiscount.ToString()).ToString("#,## VNĐ").Replace(',', '.'),
                };
                billDetails.Add(details);

            }
            lblTotalMoney.Text = TotalMoneyBeforeDiscount.ToString("#,## VNĐ").Replace(',', '.');
            dgvBillDetail.DataSource = billDetails;
            
            lblDiscount.Text = (TotalMoneyBeforeDiscount - TotalPayAfterDiscount).ToString("#,## VNĐ").Replace(',', '.');
            if (bill.used_points > 0)
            {
                TotalPayAfterDiscount -= (int)bill.used_points * 1000;
            }
            if (TotalPayAfterDiscount == 0)
            {
                lblTotalPay.Text = "0";
            }
            else lblTotalPay.Text = TotalPayAfterDiscount.ToString("#,## VNĐ").Replace(',', '.');
            lblUsedPoint.Text = bill.used_points.ToString();
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
    }
}
