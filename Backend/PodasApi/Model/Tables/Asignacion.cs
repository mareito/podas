using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("asignaciones")]
    public class Asignacion : Auditoria
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("id_programacion_poda")]
        [Required]
        public int IdProgramacionPoda { get; set; }
        
        [Column("id_detalle_programacion")]
        [Required]
        public int IdDetalleProgramacion { get; set; }

        [Column("id_municipio")]
        [Required]
        public int IdMunicipio { get; set; }
        
        [Column("id_localidad")]
        [Required]
        public int IdLocalidad { get; set; }
        
        [Column("id_barrio")]
        [Required]
        public int IdBarrio { get; set; }

        [Column("id_tercero")]
        [Required]
        public int IdContratista { get; set; }               

        [Column("id_cuadrilla")]
        [Required]
        public int IdCuadrilla { get; set; }        

        [Column("total_censado_inicial")]
        [Required]
        public int TotalCensadoInicial { get; set; }

        [Column("total_no_censado_inicial")]
        [Required]
        public int TotalNoCensadoInicial { get; set; }

        [Column("total_censado_final")]
        [Required]
        public int TotalCensadoFinal { get; set; }

        [Column("total_no_censado_final")]
        [Required]
        public int TotalNoCensadoFinal { get; set; }


        public DetalleProgramacion DetalleProgramacion { get; set; }
        public ProgramacionPoda ProgramacionPoda { get; set; }
        public Municipio Municipio { get; set; }
        public Localidad Localidad { get; set; }
        public Barrio Barrio { get; set; }
        public Tercero Tercero { get; set; }
        public Cuadrilla Cuadrilla { get; set; }

        public List<DetalleAsignacion> DetalleAsignaciones { get; set; }

    }
}
