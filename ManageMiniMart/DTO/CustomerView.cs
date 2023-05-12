using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMiniMart.DTO
{
    internal class CustomerView
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string BirthDate { get; set; }
        public int Point { get; set; }
        public string Email { get; set; }
    }
}
