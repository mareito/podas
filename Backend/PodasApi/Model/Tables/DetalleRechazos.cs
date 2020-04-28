using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("detalle_rechazos")]
    public class DetalleRechazos
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("id_arbol")]
        [Required]
        public int IdArbol { get; set; }
        
        [Column("id_tercero")]
        [Required]
        public int IdTercero { get; set; }
       
        [Column("fecha_novedad")]
        [Required]
        public DateTime FechaNovedad { get; set; }

        [Column("observacion")]
        [Required]
        [StringLength(100)]
        public string Observacion { get; set; }

        [Column("corregir")]
        [Required]
        public bool Corregir { get; set; }

        [Column("inactivar")]
        [Required]
        public bool Inactivar { get; set; }


        public Arbol Arbol { get; set; }
        public Tercero Tercero { get; set; }
    }
}
