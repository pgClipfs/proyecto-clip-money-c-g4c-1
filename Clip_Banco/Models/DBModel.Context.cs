﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clip_Banco.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Wallet_VirtualEntities : DbContext
    {
        public Wallet_VirtualEntities()
            : base("name=Wallet_VirtualEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CajaCryptoMoneda> CajaCryptoMoneda { get; set; }
        public virtual DbSet<CajaMonedaExtranjera> CajaMonedaExtranjera { get; set; }
        public virtual DbSet<CajaMonedaLocal> CajaMonedaLocal { get; set; }
        public virtual DbSet<CVU> CVU { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<Inversiones> Inversiones { get; set; }
        public virtual DbSet<Operaciones> Operaciones { get; set; }
        public virtual DbSet<Servicios> Servicios { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}