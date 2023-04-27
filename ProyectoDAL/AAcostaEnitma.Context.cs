﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoDAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AAcostaEnitmaEntities : DbContext
    {
        public AAcostaEnitmaEntities()
            : base("name=AAcostaEnitmaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Empleado> Empleadoes { get; set; }
        public virtual DbSet<ExaCatalogoProducto> ExaCatalogoProductoes { get; set; }
        public virtual DbSet<Departamento> Departamentoes { get; set; }
    
        public virtual ObjectResult<sp_GetAllCatalogoProd_Result> sp_GetAllCatalogoProd()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAllCatalogoProd_Result>("sp_GetAllCatalogoProd");
        }
    
        public virtual int sp_InsCatalogoProd(string descripción)
        {
            var descripciónParameter = descripción != null ?
                new ObjectParameter("Descripción", descripción) :
                new ObjectParameter("Descripción", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsCatalogoProd", descripciónParameter);
        }
    }
}