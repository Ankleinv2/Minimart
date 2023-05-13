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
        public List<Discount> getAllDiscount()
        {
            return db.Discounts.ToList();
        }
        public List<CBBItem> getCBBDiscount() {                         // combobox Discount
            List<CBBItem> list = new List<CBBItem>();
            var p = db.Discounts.ToList();
            list.Add(new CBBItem
            {
                Value = 0,
                Text = "None"
            });
            foreach (var item in p)
            {
                if (item.end_time >= DateTime.Now && item.start_time <= DateTime.Now)
                {
                    list.Add(new CBBItem
                    {
                        Value = item.discount_id,
                        Text = item.discount_name
                    });
                }
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
            db = null;
            db = new Manage_MinimartEntities();
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
            var product_Discount = db.Product_Discount.Where(p => p.discount_id == discount.discount_id).ToList();
            foreach (var item in product_Discount)
            {
                db.Product_Discount.Remove(item);
            }
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
