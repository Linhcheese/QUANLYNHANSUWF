﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLNHANSUEntities : DbContext
    {
        public QLNHANSUEntities()
            : base("name=QLNHANSUEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TB_BANGCONG> TB_BANGCONG { get; set; }
        public virtual DbSet<TB_BAOHIEM> TB_BAOHIEM { get; set; }
        public virtual DbSet<TB_BOPHAN> TB_BOPHAN { get; set; }
        public virtual DbSet<TB_CHUCVU> TB_CHUCVU { get; set; }
        public virtual DbSet<TB_CONGTY> TB_CONGTY { get; set; }
        public virtual DbSet<TB_DANTOC> TB_DANTOC { get; set; }
        public virtual DbSet<TB_HOPDONG> TB_HOPDONG { get; set; }
        public virtual DbSet<TB_KHENTHUONG_KYLUAT> TB_KHENTHUONG_KYLUAT { get; set; }
        public virtual DbSet<TB_LOAICA> TB_LOAICA { get; set; }
        public virtual DbSet<TB_LOAICONG> TB_LOAICONG { get; set; }
        public virtual DbSet<TB_NHANVIEN> TB_NHANVIEN { get; set; }
        public virtual DbSet<TB_NHANVIEN_PHUCAP> TB_NHANVIEN_PHUCAP { get; set; }
        public virtual DbSet<TB_PHONGBAN> TB_PHONGBAN { get; set; }
        public virtual DbSet<TB_PHUCAP> TB_PHUCAP { get; set; }
        public virtual DbSet<TB_TANGCA> TB_TANGCA { get; set; }
        public virtual DbSet<TB_TONGIAO> TB_TONGIAO { get; set; }
        public virtual DbSet<TB_TRINHDO> TB_TRINHDO { get; set; }
        public virtual DbSet<TB_UNGLUONG> TB_UNGLUONG { get; set; }
    }
}
