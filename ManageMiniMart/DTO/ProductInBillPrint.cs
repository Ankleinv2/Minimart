using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManageMiniMart.DTO
{
    internal class ProductInBillPrint
    {//product name, price, so luong, money
        private string _ProductName;
        private string _Price;
        private int _Quantity;
        private string _Total;

        public string ProductName { get => _ProductName; set => _ProductName = value; }
        public string Price { get => _Price; set => _Price = value; }
        public int Quantity { get => _Quantity; set => _Quantity = value; }
        public string Total { get => _Total; set => _Total = value; }
    }
}
