//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_project
{
    using System;
    using System.Collections.Generic;
    
    public partial class outResiet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public outResiet()
        {
            this.out_product = new HashSet<out_product>();
        }
    
        public int num { get; set; }
        public Nullable<int> store_id { get; set; }
        public string date { get; set; }
        public Nullable<int> customer_id { get; set; }
    
        public virtual store store { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<out_product> out_product { get; set; }
        public virtual custom custom { get; set; }
    }
}
