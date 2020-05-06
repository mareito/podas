using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class CuadrillaDTO
    {
        public int Id { get; set; }
        public int Descripcion { get; set; }
        public int TerceroId { get; set; }
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
        public TerceroDTO Tercero { get; set; }
        public List<AsignacionDTO> Asignaciones { get; set; }
        public List<DetalleAsignacionDTO> DetalleAsignaciones { get; set; }

    }
}
