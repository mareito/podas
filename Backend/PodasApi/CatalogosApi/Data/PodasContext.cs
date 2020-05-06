using Microsoft.EntityFrameworkCore;
using PodasApi.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PodasApi.Catalogo.Data
{
    public class PodasContext : DbContext
    {

        public PodasContext(DbContextOptions<PodasContext> options) : base(options)
        {
        }

        public DbSet<Arbol> Arboles { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Barrio> Barrios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Municipio>()
                .HasOne<Departamento>(m => m.Departamento)
                .WithMany(d => d.Municipios)
                .HasForeignKey(m => m.IdDepartamento);
        }

    }
}
