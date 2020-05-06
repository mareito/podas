using PodasApi.Entities.Tables;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PodasApi.Entities
{
    [Table("detalle_asignacion")]
    public class DetalleAsignacion
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int AsignacionId { get; set; }
        
        [Required]
        public int ArbolId { get; set; }
        
        [Required]
        public int TerceroId { get; set; }
        
        [Required]
        public int CuadrillaId { get; set; }
        
        public int? TipoIntervencionId { get; set; }
        
        [Required]
        public int CategoriaInicialId { get; set; }
        
        [Required]
        public float AlturaInicial { get; set; }

        [Required]
        public float DiametroCInicial { get; set; }

        [Required]
        public float DiametroNInicial { get; set; }

        [Required]
        public int CategoriaFinalId { get; set; }
        
        [Required]
        public float AlturaFinal { get; set; }

        [Required]
        public float DiametroCFinal { get; set; }

        [Required]
        public float DiametroNFinal { get; set; }

        public int? EstadoFisicoId { get; set; }        

        public int? EstadoFitosanitarioId { get; set; }
        
        public DateTime? FechaEjecucion { get; set; }

        public int? TipoNovedadPodaId { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Observacion { get; set; }

        [Required]
        public int NumeroRadicado { get; set; }

        
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


        [ForeignKey("ArbolId")]
        public Arbol Arbol { get; set; }  

        public Asignacion Asignacion { get; set; }
        public Tercero Tercero { get; set; } 
        public Cuadrilla Cuadrilla { get; set; }     
        public TipoIntervencion TipoIntervencion { get; set; }
        public CategoriaArbol CategoriaInicial { get; set; } 
        public CategoriaArbol CategoriaFinal { get; set; }
        public EstadoFisico EstadoFisico { get; set; }
        public EstadoFitosanitario EstadoFitosanitario { get; set; }
        public TipoNovedadPoda TipoNovedadPoda { get; set; }

    }
}
