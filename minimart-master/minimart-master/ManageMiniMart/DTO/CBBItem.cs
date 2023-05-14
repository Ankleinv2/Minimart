using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMiniMart.DTO
{
    public class CBBItem
    {
        public int Value { get; set; } 
        public string Text { get; set; }    
        public CBBItem() { }
        public override string ToString()
        {
            return Text; 
        }
    }
}
