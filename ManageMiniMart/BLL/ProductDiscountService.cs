using ManageMiniMart.DAL;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMiniMart.BLL
{
 
    public class ProductDiscountService
    {
        private Manage_MinimartEntities db;
        public ProductDiscountService()
        {
            db = new Manage_MinimartEntities();
        }
        // Get
        public Product_Discount getProduct_DiscountByProductIdAndDiscountId(int productId, int discountId)
        {
            return db.Product_Discount.Where(p => p.product_id == productId && p.discount_id == discountId).FirstOrDefault();
        }
        // Add
        public void saveProduct_Discount(Product_Discount product_Discount)
        {
            db.Product_Discount.Add(product_Discount);
            db.SaveChanges();
        }
        // Delete
        public void deleteProduct_Discount(Product_Discount product_Discount)
        {
            if (product_Discount != null)
            {
                db.Product_Discount.Remove(product_Discount);
                db.SaveChanges();
            }
        }
    }
}
