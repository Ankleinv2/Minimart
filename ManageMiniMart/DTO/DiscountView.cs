using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMiniMart.DTO
{
    internal class DiscountView
    {
        private int _id;
        private string _name;
        private string _startTime;
        private string _endTime;
        private int _percentSale;
        private string _products;               // danh sách Product

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string StartTime { get => _startTime; set => _startTime = value; }
        public string EndTime { get => _endTime; set => _endTime = value; }
        public int PercentSale { get => _percentSale; set => _percentSale = value; }
        public string Products { get => _products; set => _products = value; }
    }
}
