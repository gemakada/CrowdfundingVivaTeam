﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CrowdFundingViva1Entities : DbContext
    {
        public CrowdFundingViva1Entities()
            : base("name=CrowdFundingViva1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<payment> payment { get; set; }
        public virtual DbSet<project> project { get; set; }
        public virtual DbSet<project_category> project_category { get; set; }
        public virtual DbSet<project_funding_level> project_funding_level { get; set; }
        public virtual DbSet<project_photo> project_photo { get; set; }
        public virtual DbSet<project_state> project_state { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<user_address> user_address { get; set; }
        public virtual DbSet<user_photo> user_photo { get; set; }
    }
}
