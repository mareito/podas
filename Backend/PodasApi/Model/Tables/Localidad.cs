using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("localidades")]
    public class Localidad : Auditoria
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("nombre")]
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Column("id_municipio")]
        [Required]
        public int IdMunicipio { get; set; }

        public Municipio Municipio { get; set; }

        List<Asignacion> Asignaciones { get; set; }
        List<Arbol> Arboles { get; set; }
        List<Barrio> Barrios { get; set; }
    }
}
