using Microsoft.EntityFrameworkCore;
using Shared.Models;
using Shared1.Models;

namespace FinalProject.Dal
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Demandas> Demandas { get; set; }
        public DbSet<Expedientes> Expedientes { get; set; }
        public DbSet<Sentencias> Sentencias { get; set; }
        public DbSet<Audiencias> Audiencias { get; set; }
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<TiposDemandas> TiposDemandas { get; set; }
        public DbSet<TipoResoluciones> TipoResoluciones { get; set; }
        public DbSet<Abogados> Abogados { get; set; }
        public DbSet<Demandados> Demandados { get; set; }
        public DbSet<Niños> Niños { get; set; }
        public DbSet<EstadosDemandas> EstadosDemandas { get; set; }
        public DbSet<EmpleadoSentencia> EmpleadoSentencia { get; set; }



        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Abogados>().HasData(new List<Abogados>()
        //{
        //    new Abogados (){ AbogadoId=1,Nombre="Juan Perez",ColegioAbogadoId=234, UsuarioId=1 },
        //});

        //    modelBuilder.Entity<TipoResoluciones>().HasData(new List<TipoResoluciones>()
        //{
        //    new TipoResoluciones (){ TipoResolcion ="Hola",ResolucionId=1 },
        //});
        //    modelBuilder.Entity<EstadosDemandas>().HasData(new List<EstadosDemandas>()
        //{
        //    new EstadosDemandas (){ Estado ="Hola",EstadoId=1 },
        //});
        //    modelBuilder.Entity<Usuarios>().HasData(new List<Usuarios>()
        //{
        //    new Usuarios (){ UsuarioId =1,Nombre="Jose",FechaCreacion=DateTime.Now,Correo="",Clave="2929",Rol="Hola",Telefono=33832, Expedientes  },
        //});

        //}
        

    }
}
