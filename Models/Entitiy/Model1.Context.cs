﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RodinaTurkey.Models.Entitiy
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RodinaTurkeyEntities : DbContext
    {
        public RodinaTurkeyEntities()
            : base("name=RodinaTurkeyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tbl_Abouts> Tbl_Abouts { get; set; }
        public virtual DbSet<Tbl_Contact> Tbl_Contact { get; set; }
        public virtual DbSet<Tbl_Login> Tbl_Login { get; set; }
        public virtual DbSet<Tbl_Pickup> Tbl_Pickup { get; set; }
        public virtual DbSet<Tbl_Rentcar> Tbl_Rentcar { get; set; }
        public virtual DbSet<Tbl_RentCategory> Tbl_RentCategory { get; set; }
        public virtual DbSet<Tbl_RentContent> Tbl_RentContent { get; set; }
        public virtual DbSet<Tbl_Reservation> Tbl_Reservation { get; set; }
        public virtual DbSet<Tbl_SalesList> Tbl_SalesList { get; set; }
    }
}