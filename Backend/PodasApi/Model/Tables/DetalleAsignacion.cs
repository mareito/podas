using PodasApi.Entities.Enums;
using PodasApi.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities
{
    [Table("detalle_asignacion")]
    public class DetalleAsignacion : Auditoria
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("id_asignacion")]
        [Required]
        public int IdAsignacion { get; set; }
        
        [Column("id_arbol")]
        [Required]
        public int IdArbol { get; set; }
        
        [Column("id_tercero")]
        [Required]
        public int IdTercero { get; set; }
        
        [Column("id_cuadrilla")]
        [Required]
        public int IdCuadrilla { get; set; }
        
        [Column("id_tipo_intevencion")]        
        public int? IdTipoIntervencion { get; set; }
        
        [Column("id_categoria_inicial")]
        [Required]
        public int IdCategoriaInicial { get; set; }
        
        [Column("altura_inicial")]
        [Required]
        public float AlturaInicial { get; set; }

        [Column("diametro_c_inicial")]
        [Required]
        public float DiametroCInicial { get; set; }

        [Column("diametro_n_inicial")]
        [Required]
        public float DiametroNInicial { get; set; }

        [Column("id_categoria_final")]
        [Required]
        public int IdCategoriaFinal { get; set; }
        
        [Column("altura_final")]
        [Required]
        public float AlturaFinal { get; set; }

        [Column("diametro_c_final")]
        [Required]
        public float DiametroCFinal { get; set; }

        [Column("diametro_n_final")]
        [Required]
        public float DiametroNFinal { get; set; }

        [Column("id_estado_fisico")]
        public int? IdEstadoFisico { get; set; }        

        [Column("id_estado_fitosanitario")]        
        public int? IdEstadoFitosanitario { get; set; }
        
        [Column("fecha_ejecucion")]
        public DateTime? FechaEjecucion { get; set; }

        [Column("id_tipo_novedad")]        
        public int? IdTipoNovedad { get; set; }
        
        [Column("observacion")]
        [Required]
        [StringLength(100)]
        public string Observacion { get; set; }

        [Column("numero_radicado")]
        [Required]
        public int NumeroRadicado { get; set; }

        public Arbol Arbol { get; set; }        //
        public Asignacion Asignacion { get; set; } //
        public Tercero Tercero { get; set; }    //
        public Cuadrilla Cuadrilla { get; set; }      // 
        public TipoIntervencion TipoIntervencion { get; set; } //
        public CategoriaArbol CategoriaInicial { get; set; } //
        public CategoriaArbol CategoriaFinal { get; set; }
        public EstadoFisico EstadoFisico { get; set; }
        public EstadoFitosanitario EstadoFitosanitario { get; set; }
        public TipoNovedadPoda TipoNovedadPoda { get; set; }

    }
}
