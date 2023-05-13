using ManageMiniMart.DAL;
using ManageMiniMart.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace ManageMiniMart.BLL
{
    internal class BillService
    {
        private Manage_MinimartEntities db;
        private Bill_ProductService bill_ProductService;
        public int IdBillAdded;
        
        public BillService()
        {
            db= new Manage_MinimartEntities();
            bill_ProductService= new Bill_ProductService();
        }
        public List<BillView> convertToBillView(List<Bill> bills)
        {
            List<BillView> result = new List<BillView>();
            foreach(Bill bill in bills)
            {
                var productInBill = db.Bill_Product.Where( b => b.bill_id == bill.bill_id ).ToList();
                double total = 0;
                foreach( var product in productInBill)
                {
                    total += product.price*product.quantity;
                }
                if (bill.used_points > 0)
                {
                    total -= (int)bill.used_points * 1000;
                }
                result.Add(new BillView
                {
                    Id= bill.bill_id,
                    CustomerName = bill.Customer != null ? bill.Customer.customer_name :"Unknow",
                    EmployeeName = bill.Person.person_name,
                    CreatedTime = bill.created_time.ToString(),
                    Total= total != 0 ? total.ToString("#,## VNĐ").Replace(',', '.') : "0 VNĐ",
                });
            }
            return result;
        }
        // Get
        public List<BillView> getAllBillView()
        {
            var bills = db.Bills.ToList();
            return convertToBillView(bills);
        }
        public Bill getBillById(int id)
        {
            return db.Bills.Find(id);
        }
        public List<BillView> getAllBillViewByCustomerName(string customerName)
        {
            if (customerName == "")
            {
                var bills = db.Bills.ToList();
                return convertToBillView(bills);
            }
            else
            {
                var bills = db.Bills.Where(b => b.Customer.customer_name.Contains(customerName)).ToList();
                return convertToBillView(bills);
            }
        }
        public double getTotalByBill(int billId)
        {
            Bill bill = getBillById(billId);
            double total = 0;
            foreach (Bill_Product bill_Product in bill_ProductService.getBill_ProductByBillId(billId))
            {
                total += bill_Product.price * bill_Product.quantity;
            }
            if (bill.used_points > 0)
            {
                total -= (int)bill.used_points * 1000;
            }
            return total;
        }
        // Add
        public void saveBill(Bill bill)
        {
            db.Bills.AddOrUpdate(bill);
            db.SaveChanges();
            this.IdBillAdded = bill.bill_id;
        }
        // Sort
        public List<BillView> getAllBillViewSortBy(string s,int flag)
        {
            var list=getAllBillView();
            if (s == "CreatedTime")
            {
                if(flag == 0)
                {
                    list=list.OrderBy(x => x.CreatedTime).ToList();
                }
                else
                {
                    list= list.OrderByDescending(x => x.CreatedTime).ToList();
                }
            }
            else if(s== "Total Money")
            {
                if (flag == 0)
                {
                    list = list.OrderBy(x => x.Total).ToList();
                }
                else
                {
                    list = list.OrderByDescending(x => x.Total).ToList();
                }
            }
            
            return list;
        }
        public List<BillView> getAllBillViewByBillDate(DateTime bill_date)
        {
            var bills = db.Bills.Where(b => DbFunctions.TruncateTime(b.created_time) == bill_date).ToList(); //stackoverflow.com/questions/14601676/the-specified-type-member-date-is-not-supported-in-linq-to-entities-only-init
            return convertToBillView(bills);
        }
    }
}
