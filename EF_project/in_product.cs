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
    
    public partial class in_product
    {
        public int item_code { get; set; }
        public int inresiet_num { get; set; }
        public Nullable<int> quantity { get; set; }
        public System.DateTime production_date { get; set; }
        public Nullable<System.DateTime> expired_date { get; set; }
        public Nullable<int> validity { get; set; }
    
        public virtual item item { get; set; }
        public virtual suplyReset suplyReset { get; set; }
    }
}