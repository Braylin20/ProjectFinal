using Microsoft.EntityFrameworkCore;
using Shared.Models;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Abogados>().HasData(new List<Abogados>()
        {
            new Abogados (){ AbogadoId=1,Nombre="Juan Perez" },
            new Abogados (){ AbogadoId=2,Nombre="Elizabeth Mata" },
            new Abogados (){ AbogadoId=3,Nombre="Palito De Coco" }
        });
        }

    }
}
