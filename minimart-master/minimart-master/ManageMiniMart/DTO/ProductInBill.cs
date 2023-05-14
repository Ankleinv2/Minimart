using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMiniMart.DTO
{
    internal class ProductInBill
    {
        private int _productId;
        private string _name;
        private double _price;
        private int _quantity;
        private string _category_name;
        private int _discountId;
        private string _sale;
        private string _brand;
        private int _amount;
        public int ProductId { get => _productId; set => _productId = value; }
        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public string Category_name { get => _category_name; set => _category_name = value; }
        public int DiscountId { get => _discountId; set => _discountId = value; }
        public string Sale { get => _sale; set => _sale = value; }
        public string Brand { get => _brand; set => _brand = value; }
        public int Amount { get => _amount; set => _amount = value; }
        
    }
}
