using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace PodasApi.Entities.Tables
{

    public class CambioEstadoDTO
    {
        public int Id { get; set; }
        public int ArbolId { get; set; }
        private string estadoAnterior;
        public Estados getEstadoAnterior()
        {
            return ConvertirEstadosDTO.ConvertirEstado(this.estadoAnterior);
        }
        public void setEstadoAnterior(Estados estadoAnterior)
        {
            this.estadoAnterior = ConvertirEstadosDTO.ConvertirEstado(estadoAnterior);
        }
        private string estadoActual;
        public Estados getEstadoActual()
        {
            return ConvertirEstadosDTO.ConvertirEstado(this.estadoActual);
        }
        public void setEstadoActual(Estados estadoActual)
        {
            this.estadoActual = ConvertirEstadosDTO.ConvertirEstado(estadoActual);
        }
        public string Observacion { get; set; }
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

    }
}
