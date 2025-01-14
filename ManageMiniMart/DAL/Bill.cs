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
    
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            this.Bill_Product = new HashSet<Bill_Product>();
        }
    
        public int bill_id { get; set; }
        public string person_id { get; set; }
        public string customer_id { get; set; }
        public System.DateTime created_time { get; set; }
        public string payment_method { get; set; }
        public Nullable<int> used_points { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Person Person { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill_Product> Bill_Product { get; set; }
    }
}
