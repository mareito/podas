using PodasApi.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class Auditoria
    {
        [Column("estados")]
        [Required]
        private string estado;
        
        public Estados getEstado()
        {
            return ConvertirEstados.ConvertirEstado(this.estado);
        }

        public void setEstado(Estados estado)
        {
            this.estado = ConvertirEstados.ConvertirEstado(estado);
        }

        [Column("usuario_creacion")]
        [StringLength(20)]
        [Required]
        public string UsuarioCreacion { get; set; }

        [Column("fecha_creacion")]
        [Required]
        public DateTime FechaCreacion { get; set; }

        [Column("usuario_modifica")]
        [StringLength(20)]
        public string UsuarioModificacion { get; set; }

        [Column("fecha_modifica")]
        public DateTime FechaModificacion { get; set; }
    }
}
