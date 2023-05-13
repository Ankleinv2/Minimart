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
    public partial class Details_Bill_Print : Form
    {
        private Bill_ProductService bill_ProductService;
        private BillService billService;
        public Details_Bill_Print()
        {
            InitializeComponent();
            bill_ProductService = new Bill_ProductService();
            billService = new BillService();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();

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

        public void setDatagridView(int billId)
        {
            Bill bill = billService.getBillById(billId);
            lblStaff.Text = bill.Person.person_name;
            lblBillDate.Text = bill.created_time.ToString();
            if (bill.Customer != null)
            {
                lblCustomer.Text = bill.Customer.customer_name;
            }
            else lblCustomer.Text = "";
            List<Bill_Product> getAllProductInBill = bill_ProductService.getBill_ProductByBillId
                (billId);
            List<BillDetailView> billDetails = new List<BillDetailView>();

            foreach (Bill_Product bill_Product in getAllProductInBill)
            {

                BillDetailView details = new BillDetailView
                {
                    Product_id = bill_Product.Product.product_id,
                    Product_name = bill_Product.Product.product_name,
                    Quantity = bill_Product.quantity,
                    Price = bill_Product.price.ToString(),
                    Total = (bill_Product.price * bill_Product.quantity).ToString()

                };
                billDetails.Add(details);

            }

            String content = "";
            content += "Product name".PadRight(25);
            content += "Price".PadLeft(15);
            content += "SL".PadLeft(7);
            content += "Money".PadLeft(20) + "\n";
            foreach (BillDetailView details in billDetails)
            {
                string productName = details.Product_name.PadRight(25);
                content += productName;
                string price = details.Price.PadLeft(15);
                content += price;
                string quantity = ("x " + details.Quantity.ToString()).PadLeft(7);
                content += quantity;
                string totalMoney = details.Total.PadLeft(20);
                content += totalMoney + "\n";

            }
            string used_point = ("Used point: " + bill.used_points.ToString()).PadLeft(67);
            content += used_point + "\n";
            content += "\n";
            string TotalMoneyInBill = "";
            if (billService.getTotalByBill(billId) != 0)
            {
                TotalMoneyInBill = ("ToTal: " + billService.getTotalByBill(billId).ToString("#,## VNĐ").Replace(',', '.')).PadLeft(67);

            }
            else
            {
                TotalMoneyInBill = ("ToTal: 0 VNĐ").PadLeft(67);
            }
            content += TotalMoneyInBill;
            lblContent.Text = "";
            lblContent.Text = content;
            Console.WriteLine(content);
        }
    }
}
