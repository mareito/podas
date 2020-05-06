using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PodasApi.Entities.Tables
{
    public class BarrioDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int MunicipioId { get; set; }
        public int LocalidadId { get; set; }
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
        public virtual MunicipioDTO Municipio { get; set; }
        public virtual LocalidadDTO Localidad { get; set; }
        public virtual List<AsignacionDTO> Asignaciones { get; set; }
        public virtual List<ArbolDTO> Arboles { get; set; }
    }
}
