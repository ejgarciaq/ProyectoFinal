//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PF.DB.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PF_IS39Entities : DbContext
    {
        public PF_IS39Entities()
            : base("name=PF_IS39Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Estado_Tarjeta> Estado_Tarjeta { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Solicitud_Tarjeta> Solicitud_Tarjeta { get; set; }
        public virtual DbSet<Tarjeta> Tarjetas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}
