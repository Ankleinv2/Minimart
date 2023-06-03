using ManageMiniMart.BLL;
using ManageMiniMart.DAL;
using ManageMiniMart.DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageMiniMart.View
{
    public partial class FormBillPrint : Form
    {
        private Bill_ProductService bill_ProductService;
        private BillService billService;
        private int BillId;
        public FormBillPrint(int billID)
        {
            InitializeComponent();
            bill_ProductService = new Bill_ProductService();
            billService = new BillService();
            BillId = billID;
        }

        private void FormBillPrint_Load(object sender, EventArgs e)
        {
            Bill bill = billService.getBillById(BillId);
            List<Bill_Product> products = bill_ProductService.getBill_ProductByBillId(BillId);
            List<ProductInBillPrint> list = new List<ProductInBillPrint>();
            foreach (Bill_Product product in products)
            {
                ProductInBillPrint productInBillPrint = new ProductInBillPrint();
                productInBillPrint.ProductName = product.Product.product_name;
                productInBillPrint.Price = product.price.ToString("#,## VNĐ").Replace(',', '.');
                productInBillPrint.Quantity = product.quantity;
                productInBillPrint.Total = (product.quantity * product.price).ToString("#,## VNĐ").Replace(',', '.');

                list.Add(productInBillPrint);
            }

            reportViewer1.LocalReport.ReportPath = "H:\\OneDrive - The University of Technology\\PBL3\\PBL3_MiniMart\\minimart-master\\minimart-master\\ManageMiniMart\\View\\BillDetail.rdlc";
            var source = new ReportDataSource("ProductInBill", list);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[]
            {
                new ReportParameter("BillID",Convert.ToInt32(bill.bill_id).ToString()),
                new ReportParameter("DateTime", bill.created_time.ToString()),
                new ReportParameter("Cashier",bill.Person.person_name),
                new ReportParameter("TotalDiscount",bill.used_points != null ? ((int)bill.used_points * 1000).ToString("#,## VNĐ").Replace(',', '.') : "0 VNĐ"),
                new ReportParameter("CustomerID",bill.customer_id != null ? bill.customer_id : "Khách lẻ"),
                new ReportParameter("Point", bill.customer_id != null && billService.getTotalByBill(BillId) != 0 ? Convert.ToInt32((int)billService.getTotalByBill(BillId) / 20000).ToString() : "0"),
                new ReportParameter("TotalMoney", billService.getTotalByBill(BillId) != 0 ? billService.getTotalByBill(BillId).ToString("#,## VNĐ").Replace(',', '.') : "0 VNĐ")
            });
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);

            this.reportViewer1.RefreshReport();
        }
    }
}
