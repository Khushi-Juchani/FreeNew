//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADPDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Availability
    {
        public Nullable<int> EventID { get; set; }
        public Nullable<System.DateTime> Availability1 { get; set; }
        public int EID { get; set; }
    
        public virtual Event Event { get; set; }
    }
}