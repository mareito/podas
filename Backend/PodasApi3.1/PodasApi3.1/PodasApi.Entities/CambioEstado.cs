using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace PodasApi.Entities.Tables
{

    [Table("cambios_estado")]
    public class CambioEstado
    {
        [Key]        
        [Required]
        public int Id { get; set; }
        
        [Required]        
        public int ArbolId { get; set; }

        [Required]
        [StringLength(1)]
        private string estadoAnterior;
        public Estados getEstadoAnterior()
        {
            return ConvertirEstados.ConvertirEstado(this.estadoAnterior);
        }

        public void setEstadoAnterior(Estados estadoAnterior)
        {
            this.estadoAnterior = ConvertirEstados.ConvertirEstado(estadoAnterior);
        }

        [Required]
        [StringLength(1)]
        private string estadoActual;
        public Estados getEstadoActual()
        {
            return ConvertirEstados.ConvertirEstado(this.estadoActual);
        }
        public void setEstadoActual(Estados estadoActual)
        {
            this.estadoActual = ConvertirEstados.ConvertirEstado(estadoActual);
        }
        
        [Required]
        [StringLength(100)]
        public string Observacion { get; set; }

        
        public string Estado { get; set; }

        public Estados getEstado()
        {
            return ConvertirEstados.ConvertirEstado(this.Estado);
        }

        public void setEstado(Estados estado)
        {
            this.Estado = ConvertirEstados.ConvertirEstado(estado);
        }

        [StringLength(20)]
        [Required]
        public string UsuarioCreacion { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        [StringLength(20)]
        public string UsuarioModificacion { get; set; }

        public DateTime FechaModificacion { get; set; }

        public Arbol Arbol { get; set; }

    }
}
