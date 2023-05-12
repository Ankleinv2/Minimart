using ManageMiniMart.DAL;
using ManageMiniMart.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ManageMiniMart.BLL
{
    internal class DiscountService
    {
        private Manage_MinimartEntities db;
        public DiscountService()
        {
            db = new Manage_MinimartEntities();
        }
        public List<CBBItem> getCBBDiscount() {                         // combobox Discount
            List<CBBItem> list = new List<CBBItem>();
            var p = db.Discounts.Select(o => new { o.discount_id, o.discount_name }).ToList();
            list.Add(new CBBItem
            {
                Value = 0,
                Text = "None"
            });
            foreach (var item in p)
            {
                list.Add(new CBBItem 
                {
                    Value = item.discount_id,
                    Text = item.discount_name 
                    
                });
            }
            return list;
        }
        public List<DiscountView> convertToDiscountView(List<Discount> discounts)
        {
            List<DiscountView> list = new List<DiscountView>();
            foreach (var discount in discounts)
            {
                string products = "";
                foreach(var item in discount.Product_Discount)
                {
                    products += item.Product.product_name + ", ";
                }
                list.Add(new DiscountView
                {
                    Id = discount.discount_id,
                    Name = discount.discount_name,
                    StartTime = String.Format("{0:MM/dd/yyyy}", discount.start_time) ,
                    EndTime = String.Format("{0:MM/dd/yyyy}", discount.end_time),
                    PercentSale = (int)discount.sale,
                    Products= products

                });
            }
            return list;
        }
        // Get
        public List<DiscountView> getAllDiscountView()
        {
            return convertToDiscountView(db.Discounts.ToList());
        }
        public Discount getDiscountById(int id)
        {
            var s1 = db.Discounts.Where(o => o.discount_id == id).FirstOrDefault();
            return s1;
        }
        public List<DiscountView> getListDiscountViewByName(string name)
        {
            List<DiscountView> l = new List<DiscountView>();
            var s=db.Discounts.Where(o => o.discount_name.Contains(name)).ToList();
            l = convertToDiscountView(s);
            return l;
        }
        // Add or Update
        public void saveDiscount(Discount discount)
        {
            db.Discounts.AddOrUpdate(discount);
            db.SaveChanges();
        }
        // Delete 1 discount
        public void deleteDiscount(Discount discount)
        {
            db.Discounts.Remove(discount);
            db.SaveChanges();
        }
        // Delete List Discount
        public void deleteListDiscount(List<Discount> listDiscount)
        {
            db.Discounts.RemoveRange(listDiscount);
            db.SaveChanges();
        }


    }
}
