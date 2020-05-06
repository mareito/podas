using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class DetalleRechazosDTO
    {
        public int Id { get; set; }
        public int ArbolId { get; set; }
        public int TerceroId { get; set; }
        public DateTime FechaNovedad { get; set; }
        public string Observacion { get; set; }
        public bool Corregir { get; set; }
        public bool Inactivar { get; set; }
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
        public TerceroDTO Tercero { get; set; }
    }
}
