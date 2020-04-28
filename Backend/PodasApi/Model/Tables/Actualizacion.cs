using PodasApi.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities
{
    [Table("actualizaciones")]
    public class Actualizacion : Auditoria
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("nombre_tabla",TypeName = "varchar(50)")]     
        [StringLength(50)]
        [Required]
        public string NombreTabla { get; set; }

        [Column("version")]
        [Required]
        public int Version { get; set; }
    }
}
