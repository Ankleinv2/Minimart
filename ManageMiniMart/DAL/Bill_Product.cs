//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManageMiniMart.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill_Product
    {
        public int product_id { get; set; }
        public int bill_id { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
    
        public virtual Bill Bill { get; set; }
        public virtual Product Product { get; set; }
    }
}
