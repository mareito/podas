using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("especie_arbol")]
    public class EspecieArbol : Auditoria
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("nombre_comun")]
        [Required]
        public string NombreComun { get; set; }

        [Column("nombre_cientifico")]
        [Required]
        public string NombreCientifico { get; set; }

        [Column("id_familia_arbol")]
        [Required]
        public int IdFamiliaArbol { get; set; }


        public FamiliaArbol FamiliaArbol { get; set; }

        List<Arbol> Arboles { get; set; }
    }
}
