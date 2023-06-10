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
using System.Windows.Media.Animation;
using System.Xml.Linq;

namespace ManageMiniMart.BLL
{
    
    internal class ProductService
    {
        private Manage_MinimartEntities db;
        private ProductDiscountService productDiscountService;
        private DiscountService discountService;
        public ProductService() { 
            db = new Manage_MinimartEntities();
            productDiscountService = new ProductDiscountService();
            discountService = new DiscountService();
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
                    Price = product.price != 0 ? product.price.ToString("#,## VNĐ").Replace(',', '.') : "0 VNĐ",
                    Quantity = product.quantity,
                    Category_name = product.Category.category_name,
                    Brand = product.brand,
                    Sale = sale
                });
            }
            return products;
        }
        // Get
        public List<ProductView> getAllProductView()
        {
            db = null;
            db = new Manage_MinimartEntities();
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
        public List<ProductView> getListProductViewByProductName(string name, int value)                    // tìm kiếm danh sách theo tên sản phẩm
        {
            List<ProductView> products = new List<ProductView>();
            var s = db.Products.Where(p => p.product_name.Contains(name) && p.quantity > value).ToList();
            products = convertToProductView(s);
            return products;
        }
        public List<ProductView> getListProductViewByProductName2(string name)                    // tìm kiếm danh sách theo tên sản phẩm
        {
            List<ProductView> products = new List<ProductView>();
            var s = db.Products
                        .Where(p => p.product_name.Contains(name) && !db.Product_Discount
                        .Select(pd => pd.product_id)
                        .Contains(p.product_id))
                        .ToList();
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
        public void saveProduct(string Id, string Name, string Brand, string Price, string Quantity, int LastDiscount, int Discount_id = 0, int Category_id = 0)
        {
            if (Name == "") throw new Exception("Name product is not empty");
            if (Brand == "") throw new Exception("Brand is not empty");
            try
            {

                Convert.ToInt32(Price);
                Convert.ToInt32(Quantity);

            }
            catch (FormatException)
            {
                throw new Exception("Price and Quantity must be a number");
            }
            if (Convert.ToInt32(Price) < 0) throw new Exception("Price can not be a negative number");
            if (Convert.ToInt32(Quantity) < 0) throw new Exception("Quantity can not be a negative number");
            if (Category_id == 0) throw new Exception("Catogory is not selected");

            if (Discount_id > 0 && Id == "")                               // add, có discount
            {
                Discount discount = discountService.getDiscountById(Discount_id);
                List<Discount> discounts = new List<Discount>();
                discounts.Add(discount);
                Product product1 = new Product
                {
                    product_name = Name,
                    category_id = Category_id,
                    brand = Brand,
                    price = Convert.ToDouble(Price),
                    quantity = Convert.ToInt16(Quantity)
                };
                saveProduct(product1);
                Product_Discount product_Discount = new Product_Discount
                {
                    product_id = product1.product_id,
                    discount_id = Discount_id,
                };
                productDiscountService.saveProduct_Discount(product_Discount);
            }
            else if (Discount_id > 0 && Id != "")                     // edit , có discount
            {
                Product product2 = new Product
                {
                    product_id = Convert.ToInt32(Id),
                    product_name = Name,
                    price = Convert.ToDouble(Price),
                    brand = Brand,
                    quantity = Convert.ToInt16(Quantity),
                    category_id = Category_id,
                };
                saveProduct(product2);
                // xoá discount cũ
                Product_Discount product_Discount1 = productDiscountService.getProduct_DiscountByProductIdAndDiscountId(product2.product_id, LastDiscount);
                productDiscountService.deleteProduct_Discount(product_Discount1);
                // thêm discount mới
                Product_Discount product_Discount = new Product_Discount
                {
                    product_id = product2.product_id,
                    discount_id = Discount_id,
                };
                productDiscountService.saveProduct_Discount(product_Discount);
            }
            else if (Discount_id == 0 && Id != "")                // edit, không có discount
            {
                Product product = new Product
                {
                    product_id = Convert.ToInt32(Id),
                    product_name = Name,
                    price = Convert.ToDouble(Price),
                    brand = Brand,
                    quantity = Convert.ToInt16(Quantity),
                    category_id = Category_id,
                };
                //
                saveProduct(product);
                //
                Product_Discount product_Discount1 = productDiscountService.getProduct_DiscountByProductIdAndDiscountId(product.product_id, LastDiscount);
                productDiscountService.deleteProduct_Discount(product_Discount1);
            }
            else                           // add khong co discount
            {
                Product product = new Product
                {
                    product_name = Name,
                    price = Convert.ToDouble(Price),
                    brand = Brand,
                    quantity = Convert.ToInt16(Quantity),
                    category_id = Category_id
                };

                saveProduct(product);
            }
        }

    }
}
