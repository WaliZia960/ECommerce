//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECommerce.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Status
    {
        public int Status_Id { get; set; }
        public int User_Id { get; set; }
        public Nullable<int> Status_Type_Id { get; set; }
    
        public virtual Tbl_Status_Type Tbl_Status_Type { get; set; }
    }
}
