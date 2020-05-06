using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{    
    public class AsignacionDTO
    {
        public int Id { get; set; }
        public int ProgramacionPodaId { get; set; }
        public int DetalleProgramacionId { get; set; }
        public int MunicipioId { get; set; }
        public int LocalidadId { get; set; }
        public int BarrioId { get; set; }
        public int ContratistaId { get; set; }               
        public int CuadrillaId { get; set; }        
        public int TotalCensadoInicial { get; set; }
        public int TotalNoCensadoInicial { get; set; }
        public int TotalCensadoFinal { get; set; }
        public int TotalNoCensadoFinal { get; set; }
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
        public virtual DetalleProgramacionDTO DetalleProgramacion { get; set; }
        public virtual ProgramacionPodaDTO ProgramacionPoda { get; set; }
        public virtual MunicipioDTO Municipio { get; set; }
        public virtual LocalidadDTO Localidad { get; set; }
        public virtual BarrioDTO Barrio { get; set; }
        public virtual TerceroDTO Tercero { get; set; }
        public virtual CuadrillaDTO Cuadrilla { get; set; }
       

    }
}
