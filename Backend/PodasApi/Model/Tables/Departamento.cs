using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("departamentos")]
    public class Departamento : Auditoria
    {
        [Key]
        [Column("id")]
        [Required]        
        public int Id { get; set;}

        [Column("nombre")]
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [InverseProperty("Departamento")]
        public List<Municipio> Municipios { get; set; }
        public List<Tercero> Terceros { get; set; }
    }
}
