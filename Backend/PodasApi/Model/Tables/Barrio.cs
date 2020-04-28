using PodasApi.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("barrios")]
    public class Barrio : Auditoria
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("nombre")]
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Column("id_municipio")]
        [Required]
        public int IdMunicipio { get; set; }

        [Column("id_localidad")]
        [Required]
        public int IdLocalidad { get; set; }
        
        public Municipio Municipio { get; set; }
        public Localidad Localidad { get; set; }

        public List<Asignacion> Asignaciones { get; set; }
        public List<Arbol> Arboles { get; set; }
    }
}
