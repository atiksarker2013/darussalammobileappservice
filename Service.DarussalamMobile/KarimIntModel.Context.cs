﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service.DarussalamMobile
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KARIM_INT_HOUSTONEEntities : DbContext
    {
        public KARIM_INT_HOUSTONEEntities()
            : base("name=KARIM_INT_HOUSTONEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_DarussalamMobileUser> tbl_DarussalamMobileUser { get; set; }
    }
}
