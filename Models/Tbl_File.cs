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
    
    public partial class Tbl_File
    {
        public int File_Id { get; set; }
        public int User_Id { get; set; }
        public string File_Path { get; set; }
        public Nullable<int> File_Type_Id { get; set; }
    
        public virtual Tbl_File_Type Tbl_File_Type { get; set; }
    }
}
