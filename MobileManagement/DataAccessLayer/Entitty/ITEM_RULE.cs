//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.Entitty
{
    using System;
    using System.Collections.Generic;
    
    public partial class ITEM_RULE
    {
        public int RuleId { get; set; }
        public int ItemId { get; set; }
        public Nullable<bool> IsShow { get; set; }
    
        public virtual ITEM ITEM { get; set; }
        public virtual RULE RULE { get; set; }
    }
}
