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
    
    public partial class out_product
    {
        public int item_code { get; set; }
        public int outresiet_num { get; set; }
        public Nullable<int> quantity { get; set; }
    
        public virtual item item { get; set; }
        public virtual outResiet outResiet { get; set; }
    }
}
