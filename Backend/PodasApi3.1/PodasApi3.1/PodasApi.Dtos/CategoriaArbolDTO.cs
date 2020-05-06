using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class CategoriaArbolDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string AlturaMinima { get; set; }
        public string AlturaMaxima { get; set; }
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
        public List<ArbolDTO> Arboles { get; set; }
        public List<DetalleAsignacionDTO> DetalleAsignacionesIniciales { get; set; }
        public List<DetalleAsignacionDTO> DetalleAsignacionesFinales { get; set; }
        public List<TarifaPodaDTO> TarifasPodas { get; set; }

    }
}
