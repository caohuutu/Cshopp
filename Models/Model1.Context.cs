﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace btap.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bc_webEntities : DbContext
    {
        public bc_webEntities()
            : base("name=bc_webEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ctdondathang> ctdondathangs { get; set; }
        public virtual DbSet<dondathang> dondathangs { get; set; }
        public virtual DbSet<hangsanxuat> hangsanxuats { get; set; }
        public virtual DbSet<nguoidung1> nguoidung1 { get; set; }
        public virtual DbSet<thongtinkhachhang> thongtinkhachhangs { get; set; }
        public virtual DbSet<thongtinmathang> thongtinmathangs { get; set; }
        public virtual DbSet<tintuc> tintucs { get; set; }
    }
}