using PodasApi.Entities.Tables;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PodasApi.Entities
{
    public class DetalleAsignacionDTO
    {
        public int Id { get; set; }
        public int AsignacionId { get; set; }
        public int ArbolId { get; set; }
        public int TerceroId { get; set; }
        public int CuadrillaId { get; set; }        
        public int? TipoIntervencionId { get; set; }
        public int CategoriaInicialId { get; set; }
        public float AlturaInicial { get; set; }
        public float DiametroCInicial { get; set; }
        public float DiametroNInicial { get; set; }
        public int CategoriaFinalId { get; set; }
        public float AlturaFinal { get; set; }
        public float DiametroCFinal { get; set; }
        public float DiametroNFinal { get; set; }
        public int? EstadoFisicoId { get; set; }        
        public int? EstadoFitosanitarioId { get; set; }
        public DateTime? FechaEjecucion { get; set; }
        public int? TipoNovedadPodaId { get; set; }
        public string Observacion { get; set; }
        public int NumeroRadicado { get; set; }
        public string Estado { get; set; }
        public Estados getEstado()
        {
            return ConvertirEstadosDTO.ConvertirEstado(this.Estado);
        }
        public void setEstado(Estados estado)
        {
            this.Estado = ConvertirEstadosDTO.ConvertirEstado(estado);
        }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public ArbolDTO Arbol { get; set; }  
        public AsignacionDTO Asignacion { get; set; }
        public TerceroDTO Tercero { get; set; } 
        public CuadrillaDTO Cuadrilla { get; set; }     
        public TipoIntervencionDTO TipoIntervencion { get; set; }
        public CategoriaArbolDTO CategoriaInicial { get; set; } 
        public CategoriaArbolDTO CategoriaFinal { get; set; }
        public EstadoFisicoDTO EstadoFisico { get; set; }
        public EstadoFitosanitarioDTO EstadoFitosanitario { get; set; }
        public TipoNovedadPodaDTO TipoNovedadPoda { get; set; }

    }
}
