using PodasApi.Entities.Enums;
using PodasApi.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities
{
    public class DetalleAsignacion : Auditoria
    {
        public int Id { get; set; }
        public int IdAsignacion { get; set; }
        public int CodigoArbol { get; set; }
        public int IdContratista { get; set; }
        public int IdCuadrilla { get; set; }
        public int IdTipoIntervencion { get; set; }
        public int IdCategoriaInicial { get; set; }
        public float AlturaInicial { get; set; }
        public float DiametroCInicial { get; set; }
        public float DiametroNInicial { get; set; }
        public int IdCategoriaFinal { get; set; }
        public float AlturaFinal { get; set; }
        public float DiametroCFinal { get; set; }
        public float DiametroNFinal { get; set; }
        public int IdEstadoFisito { get; set; }
        public int IdEstadoFitosanitario { get; set; }        
        public DateTime FechaEjecucion { get; set; }
        public int IdObservacion { get; set; }
        public string Observacion { get; set; }
        public int NumeroRadicado { get; set; }               
    }
}
