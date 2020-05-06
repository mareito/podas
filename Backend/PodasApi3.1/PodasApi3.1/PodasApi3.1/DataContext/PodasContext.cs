using Microsoft.EntityFrameworkCore;
using PodasApi.Entities;
using PodasApi.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PodasApi3._1.DataContext
{
    public class PodasContext : DbContext
    {
        public PodasContext(DbContextOptions<PodasContext> options) : base(options) {


        }

        public DbSet<Actualizacion> Actualizaciones { get; set; }
        public DbSet<Arbol> Arboles {get; set;}
        public DbSet<Asignacion> Asignaciones {get; set;}        
        public DbSet<Barrio> Barrios {get; set;}
        public DbSet<CambioEstado> CambiosEstado {get; set;}
        public DbSet<CategoriaArbol> CatagoriasArbol {get; set;}
        public DbSet<ConflictoArbol> ConflictosArbol { get; set; }
        public DbSet<Cuadrilla> Cuadrillas {get; set;}
        public DbSet<Departamento> Departamentos {get; set;}    
        public DbSet<DetalleAsignacion> DetalleAsignaciones {get; set;}
        public DbSet<DetalleProgramacion> DetalleProgramaciones {get; set;}
        public DbSet<DetalleRechazos> DetalleRechazos {get; set;}
        public DbSet<EspecieArbol> EspeciesArboles {get; set;}
        public DbSet<EstadoFisico> EstadosFisico {get; set;}
        public DbSet<EstadoFitosanitario> EstadosFitosanitario {get; set;}
        public DbSet<FamiliaArbol> FamiliasArboles {get; set;}
        public DbSet<Localidad> Localidades {get; set;}
        public DbSet<MedidasArbol> MedidasArboles {get; set;}
        public DbSet<Municipio> Municipios {get; set;}
        public DbSet<ProgramacionPoda> ProgramacionesPodas {get; set;}
        public DbSet<RiesgoArbol> RiesgoArbol {get; set;}
        public DbSet<TarifaPoda> TarifasPoda {get; set;}
        public DbSet<Tercero> Terceros {get; set;}
        public DbSet<TipoEmplazamiento> TiposEmplazamiento {get; set;}
        public DbSet<TipoIntervencion> TiposIntervencion {get; set;}
        public DbSet<TipoNovedadPoda> TipoNovedadesPodas {get; set;}        
        public DbSet<Usuario> Usuarios {get; set;}    
    }
}
