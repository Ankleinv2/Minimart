using ManageMiniMart.DAL;
using ManageMiniMart.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManageMiniMart.BLL
{
    
    internal class ProductService
    {
        private Manage_MinimartEntities db;
        public ProductService() { 
            db = new Manage_MinimartEntities();
        }
        public List<ProductView> convertToProductView(List<Product> productList) {
            List<ProductView> products = new List<ProductView>();
            foreach (var product in productList)
            {
                string sale = "";
                foreach(var discount in product.Product_Discount)
                {
                    sale += discount.Discount.discount_name + " ";
                }

                products.Add(new ProductView
                {
                    ProductId = product.product_id,
                    Name = product.product_name,
                    Price = product.price,
                    Quantity = product.quantity,
                    Category_name = product.Category.category_name,
                    Brand = product.brand,
                    Sale = sale
                }) ;
            }
            return products;
        }
        // Get
        public List<ProductView> getAllProductView()
        {
            List<ProductView> products = new List<ProductView>();
            var l = db.Products.ToList();
            products = convertToProductView(l);
            return products;
        }
        
        public Product getProductById(int id)
        {
            Product product = db.Products.Where(p => p.product_id == id).FirstOrDefault();
            return product;
        }
        public List<ProductView> getListProductViewByProductName(string name)                    // tìm kiếm danh sách theo tên sản phẩm
        {
            List<ProductView> products = new List<ProductView>();
            var s = db.Products.Where(p => p.product_name.Contains(name)).ToList();
            products = convertToProductView(s);
            return products;
        }
        public List<ProductView> getListProductViewByProductNameAndCategory(int category_id, string productName)           // tìm kiếm danh sách theo tên và danh mục
        {
            List<ProductView> products = new List<ProductView>();
            var s = db.Products.Where(p => p.product_name.Contains(productName) && p.category_id == category_id).ToList();
            products = convertToProductView(s);
            return products;
        }
        // Add or Update
        public void saveProduct(Product product)
        {
            db.Products.AddOrUpdate(product);
            db.SaveChanges();
        }
        // Delete 1 product
        public void deleteProduct(int id)
        {
            var productDiscount = db.Product_Discount.Where(p => p.product_id == id).ToList();
            db.Product_Discount.RemoveRange(productDiscount);

            var product = db.Products.Where(p => p.product_id == id).ToList();
            db.Products.RemoveRange(product);
            db.SaveChanges();
        }

    }
}
