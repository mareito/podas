using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("tipo_intervencion")]
    public class TipoIntervencion : Auditoria
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("descripcion")]
        [Required]
        [StringLength(60)]
        public string Descripcion { get; set; }

        public List<DetalleAsignacion> DetalleAsignaciones { get; set; }
    }
}
