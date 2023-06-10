using ManageMiniMart.Custom;
using ManageMiniMart.DAL;
using ManageMiniMart.DTO;
using ManageMiniMart.View;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ManageMiniMart.BLL
{
    internal class BillService
    {
        private Manage_MinimartEntities db;
        private Bill_ProductService bill_ProductService;
        private CustomerService customerService;
        private ProductService productService;
        private DiscountService discountService;
        public int IdBillAdded;

        public BillService()
        {
            db = new Manage_MinimartEntities();
            bill_ProductService = new Bill_ProductService();
            customerService = new CustomerService();
            productService = new ProductService();
            discountService = new DiscountService();
        }
        public List<BillView> convertToBillView(List<Bill> bills)
        {
            List<BillView> result = new List<BillView>();
            foreach (Bill bill in bills)
            {
                var productInBill = db.Bill_Product.Where(b => b.bill_id == bill.bill_id).ToList();
                double total = 0;
                foreach (var product in productInBill)
                {
                    total += product.price * product.quantity;
                }
                if (bill.used_points > 0)
                {
                    total -= (int)bill.used_points * 1000;
                    if (total < 0) total = 0;
                }
                result.Add(new BillView
                {
                    Id = bill.bill_id,
                    CustomerName = bill.Customer != null ? bill.Customer.customer_name : "Unknow",
                    EmployeeName = bill.Person.person_name,
                    CreatedTime = bill.created_time.ToString("dd/MM/yyyy hh:mm:ss"),
                    Total = total != 0 ? total.ToString("#,## VNĐ").Replace(',', '.') : "0 VNĐ",
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
                if (total < 0) total = 0;
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
        public bool saveBill(int QuantityinBill, string Id, string employeeId, string Payment, DateTime CurrentTime, List<ProductInBill> ProductsInBill, bool checkUsePoint)
        {
            bool haveCustomer = false;
            if (QuantityinBill == 0) throw new Exception("There are no products in the cart");
            string customerId = Id;
            Customer customer = customerService.getCustomerById(Id);
            if (customer == null)
            {
                customerId = null;
            }
            double totalMoney = 0;
            Bill bill = new Bill
            {
                person_id = employeeId,
                customer_id = customerId,
                created_time = CurrentTime,
                payment_method = Payment,

            };
            saveBill(bill);

            foreach (var product in ProductsInBill)
            {
                Product product1 = productService.getProductById(product.ProductId);
                Discount discount = discountService.getDiscountById(product.DiscountId);
                int percentOff = 0;
                if (discount != null)
                {
                    percentOff = (int)discount.sale;
                }
                totalMoney += (product.Price * (100 - percentOff) / 100) * product.Amount;

                Bill_Product bill_Product = new Bill_Product
                {
                    bill_id = IdBillAdded,
                    product_id = product.ProductId,
                    quantity = product.Amount,
                    price = product.Price * (100 - percentOff) / 100 // Lưu giá ở đây là giá sau khi đã áp dụng giảm giá
                };
                // sau khi thêm sản phẩm vào bill thì giảm số lượng hàng hóa có trong kho
                product1.quantity = product1.quantity - product.Amount;
                productService.saveProduct(product1);
                bill_ProductService.saveBill_Product(bill_Product);

            }
            if (customer != null)
            {                                                       // 20000 = 1 đ
                int oldPoint = (int)customer.point; // 1đ = 1000
                if (checkUsePoint)
                {
                    if (totalMoney < Convert.ToDouble(customer.point * 1000))
                    {
                        customer.point = (customer.point * 1000 - (int)totalMoney) / 1000;
                        totalMoney = 0;
                        bill.used_points = oldPoint - customer.point;
                    }
                    else
                    {
                        totalMoney -= Convert.ToDouble(customer.point * 1000);
                        customer.point = 0;
                        bill.used_points = oldPoint;
                    }
                }
                customer.point += (int)(totalMoney / 20000);
                saveBill(bill);
                customerService.saveCustomer(customer);
                haveCustomer = true;
            }

            FormBillPrint formBillPrint = new FormBillPrint(IdBillAdded);
            formBillPrint.ShowDialog();
            return haveCustomer;
        }
        private bool checkProduct_ExistIn_listProductInBill(List<ProductInBill> listProductInBill, int productId)                // kiểm tra xem đã add trước đó chưa
        {
            bool check = false;
            foreach (var product in listProductInBill)
            {
                if (product.ProductId == productId)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private ProductInBill getProductInBillById(List<ProductInBill> listProductInBill, int productId)
        {
            foreach (var product in listProductInBill)
            {
                if (product.ProductId == productId)
                {
                    return product;
                }
            }
            return null;
        }
        public void addProductInBill(List<ProductInBill> listProductInBill, int productId, int amount)
        {
            Product product = productService.getProductById(productId);
            string sale = "";
            int discountId = 0;
            foreach (var discount in product.Product_Discount)
            {
                sale += discount.Discount.discount_name;
                discountId = discount.Discount.discount_id;
            }
            if (amount > product.quantity)
            {
                throw new Exception("Amount product in stock not enough for buy !");
            }
            else
            {
                if (checkProduct_ExistIn_listProductInBill(listProductInBill, productId))      // Nếu đã add trước đó rồi
                {
                    ProductInBill productInBill = getProductInBillById(listProductInBill, productId);
                    int amountCurrent = productInBill.Amount;
                    if ((amountCurrent + amount) > product.quantity)
                    {
                        throw new Exception("Amount product in stock not enough for buy !");
                    }
                    else
                    {
                        productInBill.Amount += amount;

                    }

                }
                else
                {
                    listProductInBill.Add(new ProductInBill
                    {
                        ProductId = productId,
                        Name = product.product_name,
                        Brand = product.brand,
                        Price = product.price,
                        Quantity = product.quantity,
                        Amount = amount,
                        Category_name = product.Category.category_name,
                        Sale = sale,
                        DiscountId = discountId
                    });
                }
            }
        }
        // Sort
        public List<BillView> getAllBillViewSortBy(string s, int flag)
        {
            var list = getAllBillView();
            string format = "dd/MM/yyyy HH:mm:ss";
            if (s == "CreatedTime")
            {
                if (flag == 0)
                {
                    list = list.OrderBy(x => DateTime.ParseExact(x.CreatedTime, format, CultureInfo.InvariantCulture)).ToList();
                }
                else
                {
                    list = list.OrderByDescending(x => DateTime.ParseExact(x.CreatedTime, format, CultureInfo.InvariantCulture)).ToList();
                }
            }
            else if (s == "Total Money")
            {
                if (flag == 0)
                {
                    list = list.OrderBy(x => x.Total.Length).ThenBy(x => x.Total).ToList();
                }
                else
                {
                    list = list.OrderByDescending(x => x.Total.Length).ThenByDescending(x => x.Total).ToList();
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
