using ManageMiniMart.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMiniMart.BLL
{
    internal class Bill_ProductService
    {
        private Manage_MinimartEntities db;
        public Bill_ProductService()
        {
            db = new Manage_MinimartEntities();
        }
        public void saveBill_Product(Bill_Product entity)
        {
            db.Bill_Product.AddOrUpdate(entity);
            db.SaveChanges();
        }
        public List<Bill_Product> getBill_ProductByBillId(int billId)
        {
            return db.Bill_Product.Where(bill => bill.bill_id == billId).ToList();
        }
    }
}
