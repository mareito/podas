using PodasApi.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{

    [Table("cambios_estado")]
    public class CambioEstado : Auditoria
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("id_arbol")]
        [Required]        
        public int IdArbol { get; set; }

        [Column("estado_anterior")]
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

        [Column("estado_actual")]
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

        [Column("observacion")]
        [Required]
        [StringLength(100)]
        public string Observacion { get; set; }

        public Arbol Arbol { get; set; }

    }
}
