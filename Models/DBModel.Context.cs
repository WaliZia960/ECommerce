﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ecommerceEntities1 : DbContext
    {
        public ecommerceEntities1()
            : base("name=ecommerceEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Address_Type> Tbl_Address_Type { get; set; }
        public virtual DbSet<Tbl_Contact_Type> Tbl_Contact_Type { get; set; }
        public virtual DbSet<Tbl_File_Type> Tbl_File_Type { get; set; }
        public virtual DbSet<Tbl_Reg_Mode_Type> Tbl_Reg_Mode_Type { get; set; }
        public virtual DbSet<Tbl_Role_Type> Tbl_Role_Type { get; set; }
        public virtual DbSet<Tbl_Status_Type> Tbl_Status_Type { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tbl_Address> Tbl_Address { get; set; }
        public virtual DbSet<Tbl_Contact> Tbl_Contact { get; set; }
        public virtual DbSet<Tbl_File> Tbl_File { get; set; }
        public virtual DbSet<Tbl_Reg_Mode> Tbl_Reg_Mode { get; set; }
        public virtual DbSet<Tbl_Role> Tbl_Role { get; set; }
        public virtual DbSet<Tbl_Status> Tbl_Status { get; set; }
        public virtual DbSet<Tbl_User> Tbl_User { get; set; }
    
        public virtual int Insert_To_Tbl_Reg_Mode(Nullable<int> user_Id, Nullable<int> reg_Mode_Type_Id)
        {
            var user_IdParameter = user_Id.HasValue ?
                new ObjectParameter("User_Id", user_Id) :
                new ObjectParameter("User_Id", typeof(int));
    
            var reg_Mode_Type_IdParameter = reg_Mode_Type_Id.HasValue ?
                new ObjectParameter("Reg_Mode_Type_Id", reg_Mode_Type_Id) :
                new ObjectParameter("Reg_Mode_Type_Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_To_Tbl_Reg_Mode", user_IdParameter, reg_Mode_Type_IdParameter);
        }
    
        public virtual int Insert_To_Tbl_Role(Nullable<int> user_Id, Nullable<int> role_Type_Id)
        {
            var user_IdParameter = user_Id.HasValue ?
                new ObjectParameter("User_Id", user_Id) :
                new ObjectParameter("User_Id", typeof(int));
    
            var role_Type_IdParameter = role_Type_Id.HasValue ?
                new ObjectParameter("Role_Type_Id", role_Type_Id) :
                new ObjectParameter("Role_Type_Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_To_Tbl_Role", user_IdParameter, role_Type_IdParameter);
        }
    
        public virtual int Insert_To_Tbl_Status(Nullable<int> user_Id, Nullable<int> status_Type_Id)
        {
            var user_IdParameter = user_Id.HasValue ?
                new ObjectParameter("User_Id", user_Id) :
                new ObjectParameter("User_Id", typeof(int));
    
            var status_Type_IdParameter = status_Type_Id.HasValue ?
                new ObjectParameter("Status_Type_Id", status_Type_Id) :
                new ObjectParameter("Status_Type_Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_To_Tbl_Status", user_IdParameter, status_Type_IdParameter);
        }
    }
}
