﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GymSys
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LocalDBEntities : DbContext
    {
        public LocalDBEntities()
            : base("name=LocalDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Members> Members { get; set; }
        public DbSet<Memberships> Memberships { get; set; }
        public DbSet<MembershipType> MembershipType { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
