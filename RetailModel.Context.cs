﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework3
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RetailContext : DbContext
    {
        public RetailContext()
            : base("name=RetailEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Barang> Barangs { get; set; }
        public DbSet<Beli> Belis { get; set; }
        public DbSet<ItemBeli> ItemBelis { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
