﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Railway_Admin
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class testDatabaseEntities : DbContext
    {
        public testDatabaseEntities()
            : base("name=testDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alert_Table> Alert_Table { get; set; }
        public virtual DbSet<AlertInfo> AlertInfoes { get; set; }
        public virtual DbSet<BDY_R_Table> BDY_R_Table { get; set; }
        public virtual DbSet<BQI_R_Table> BQI_R_Table { get; set; }
        public virtual DbSet<DPI_R_Table> DPI_R_Table { get; set; }
        public virtual DbSet<DSPT_R_Table> DSPT_R_Table { get; set; }
        public virtual DbSet<DST_R_Table> DST_R_Table { get; set; }
        public virtual DbSet<eTable> eTables { get; set; }
        public virtual DbSet<GTable> GTables { get; set; }
        public virtual DbSet<KEY_R_Table> KEY_R_Table { get; set; }
        public virtual DbSet<KPPR_R_Table> KPPR_R_Table { get; set; }
        public virtual DbSet<LCR_R_Table> LCR_R_Table { get; set; }
        public virtual DbSet<LeaveTable> LeaveTables { get; set; }
        public virtual DbSet<mailTable> mailTables { get; set; }
        public virtual DbSet<MAP_R_Table> MAP_R_Table { get; set; }
        public virtual DbSet<newsTable> newsTables { get; set; }
        public virtual DbSet<QTable> QTables { get; set; }
        public virtual DbSet<QuResultTable> QuResultTables { get; set; }
        public virtual DbSet<SA_R_Table> SA_R_Table { get; set; }
        public virtual DbSet<sampleTable> sampleTables { get; set; }
        public virtual DbSet<SLY_R_Table> SLY_R_Table { get; set; }
        public virtual DbSet<SXT_R_Table> SXT_R_Table { get; set; }
        public virtual DbSet<TNT_R_Table> TNT_R_Table { get; set; }
        public virtual DbSet<TPT_R_Table> TPT_R_Table { get; set; }
        public virtual DbSet<AlertTable> AlertTables { get; set; }
    }
}
