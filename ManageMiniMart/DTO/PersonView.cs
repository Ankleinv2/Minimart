using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMiniMart.DTO
{
    public class PersonView
    {
        public string person_id { get; set; }
        public string person_name { get; set; }
        public string birthdate { get; set; }
        public string address { get; set; }
        public string phone_number { get; set; }
        public string salary { get; set; }
        public string email { get; set; }
    }
}
