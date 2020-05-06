using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class LocalidadDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int MunicipioId { get; set; }
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
        public MunicipioDTO Municipio { get; set; }
        public List<AsignacionDTO> Asignaciones { get; set; }
        public List<ArbolDTO> Arboles { get; set; }
        public List<BarrioDTO> Barrios { get; set; }
    }
}
