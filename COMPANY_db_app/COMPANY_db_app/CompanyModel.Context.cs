﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace COMPANY_db_app
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_COMPANYEntities : DbContext
    {
        public DB_COMPANYEntities()
            : base("name=DB_COMPANYEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<employees> employees { get; set; }
        public virtual DbSet<project_cooperation> project_cooperation { get; set; }
        public virtual DbSet<projects> projects { get; set; }
        public virtual DbSet<teams> teams { get; set; }
        public virtual DbSet<work_items> work_items { get; set; }
    }
}
