﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication8
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MotoDeliveryEntities2 : DbContext
    {
        public MotoDeliveryEntities2()
            : base("name=MotoDeliveryEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<Moto> Moto { get; set; }
        public virtual DbSet<Traslado> Traslado { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Usuario_Moto> Usuario_Moto { get; set; }
    }
}
