using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("asignaciones")]
    public class Asignacion
    {
        [Key]        
        [Required]
        public int Id { get; set; }
        
        [Required]
        public int ProgramacionPodaId { get; set; }
        
        [Required]
        public int DetalleProgramacionId { get; set; }
        
        [Required]
        public int MunicipioId { get; set; }
        
        [Required]
        public int LocalidadId { get; set; }
                
        [Required]
        public int BarrioId { get; set; }

        [Required]
        public int ContratistaId { get; set; }               

        [Required]
        public int CuadrillaId { get; set; }        

        [Required]
        public int TotalCensadoInicial { get; set; }

        [Required]
        public int TotalNoCensadoInicial { get; set; }

        [Required]
        public int TotalCensadoFinal { get; set; }

        [Required]
        public int TotalNoCensadoFinal { get; set; }

        
        public string Estado { get; set; }

        public Estados getEstado()
        {
            return ConvertirEstados.ConvertirEstado(this.Estado);
        }

        public void setEstado(Estados estado)
        {
            this.Estado = ConvertirEstados.ConvertirEstado(estado);
        }

        [StringLength(20)]
        [Required]
        public string UsuarioCreacion { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        [StringLength(20)]
        public string UsuarioModificacion { get; set; }

        public DateTime FechaModificacion { get; set; }
     
        [ForeignKey("DetalleProgramacionId")]
        public virtual DetalleProgramacion DetalleProgramacion { get; set; }

        [ForeignKey("ProgramacionPodaId")]
        public virtual ProgramacionPoda ProgramacionPoda { get; set; }

        [ForeignKey("MunicipioId")]
        public virtual Municipio Municipio { get; set; }

        [ForeignKey("LocalidadId")]
        public virtual Localidad Localidad { get; set; }

        [ForeignKey("BarrioId")]
        public virtual Barrio Barrio { get; set; }

        [ForeignKey("TerceroId")]
        public virtual Tercero Tercero { get; set; }

        [ForeignKey("CuadrillaId")]
        public virtual Cuadrilla Cuadrilla { get; set; }
       

    }
}
