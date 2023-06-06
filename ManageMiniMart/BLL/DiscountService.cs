using ManageMiniMart.Custom;
using ManageMiniMart.DAL;
using ManageMiniMart.DTO;
using ManageMiniMart.View;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Xml;

namespace ManageMiniMart.BLL
{
    internal class DiscountService
    {
        private Manage_MinimartEntities db;
        private ProductDiscountService productDiscountService;

        public DiscountService()
        {
            db = new Manage_MinimartEntities();
            productDiscountService = new ProductDiscountService();
        }
        public List<Discount> getAllDiscount()
        {
            return db.Discounts.ToList();
        }
        public List<CBBItem> getCBBDiscount()
        {                         // combobox Discount
            List<CBBItem> list = new List<CBBItem>();
            var p = db.Discounts.ToList();
            list.Add(new CBBItem
            {
                Value = 0,
                Text = "None"
            });
            foreach (var item in p)
            {
                if (item.end_time.Date >= DateTime.Now.Date && item.start_time.Date <= DateTime.Now.Date)
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
                foreach (var item in discount.Product_Discount)
                {
                    products += item.Product.product_name + ", ";
                }
                list.Add(new DiscountView
                {
                    Id = discount.discount_id,
                    Name = discount.discount_name,
                    StartTime = String.Format("{0:MM/dd/yyyy}", discount.start_time),
                    EndTime = String.Format("{0:MM/dd/yyyy}", discount.end_time),
                    PercentSale = (int)discount.sale,
                    Products = products

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
            var s = db.Discounts.Where(o => o.discount_name.Contains(name)).ToList();
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

        //
        public bool checkDiscountIsExpired(int discountId)
        {
            Discount discount = db.Discounts.Find(discountId);
            if (discount != null)
            {
                if (discount.end_time < DateTime.Now)
                {
                    MyMessageBox messageBox = new MyMessageBox();
                    messageBox.show("Discount is expired!!!");
                    return true;
                }
                return false;
            }
            else
            {
                throw new Exception("Not found discount!");

            }
        }

        // AddDiscountForm
        public void AddDiscountForm_Save(string discountID, string discountName, DateTime startTime, DateTime endTime, string txtSale)
        {
            if (discountName == "") throw new Exception("Discount name cannot be empty");
            if (DateTime.Compare(startTime, endTime) > 0) throw new Exception("End Time should be Greater Than or Equal to Start Time");
            if (DateTime.Compare(endTime, DateTime.Now.Date) < 0) throw new Exception("End Time should be Greater Than or Equal to DateTime Now");
            try
            {
                Convert.ToInt32(txtSale);
            }
            catch (Exception)
            {
                throw new Exception("Sale must be a number");
            }
            if (Convert.ToInt32(txtSale) < 0) throw new Exception("Sale can not be a negative number");
            if (Convert.ToInt32(txtSale) > 100) throw new Exception("Sale cannot over 100%");
            //
            int sale = Convert.ToInt32(txtSale);
            if (discountID != "")                     // Edit                     
            {
                int discountId = Convert.ToInt32(discountID);
                Discount discount = new Discount
                {
                    discount_id = discountId,
                    discount_name = discountName,
                    start_time = startTime,
                    end_time = endTime,
                    sale = sale
                };
                saveDiscount(discount);
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
                saveDiscount(discount);
            }
            foreach (var discount in getAllDiscount())
            {
                if (discount.end_time.Date < DateTime.Now.Date || discount.start_time.Date > DateTime.Now.Date)
                {
                    List<Product_Discount> product_s = productDiscountService.getProduct_Discount_By_DiscountID(discount.discount_id);
                    foreach (var product in product_s)
                    {
                        productDiscountService.deleteProduct_Discount(product);
                    }
                }
            }
        }
        //FormDiscount
        public void FormDiscount_Delete(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int id = Convert.ToInt32(list.ElementAt(i).ToString());
                Discount discount = getDiscountById(id);
                deleteDiscount(discount);
            }
        }
        public void FormDiscount_CellContentClick(int discountId)
        {
            if (!checkDiscountIsExpired(discountId))
            {
                SelectProductToDiscount selectProductToDiscount = new SelectProductToDiscount(discountId);
                selectProductToDiscount.ShowDialog();
            }
        }
    }
}