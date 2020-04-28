using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("cuadrillas")]
    public class Cuadrilla : Auditoria
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("nombre")]
        [Required]
        [StringLength(50)]
        public int Descripcion { get; set; }

        [Column("id_tercero")]
        [Required]
        public int IdTercero { get; set; }


        public Tercero Tercero { get; set; }

        public List<Asignacion> Asignaciones { get; set; }
        public List<DetalleAsignacion> DetalleAsignaciones { get; set; }

    }
}
