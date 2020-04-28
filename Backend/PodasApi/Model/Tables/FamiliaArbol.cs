using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("familia_arbol")]
    public class FamiliaArbol : Auditoria
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("descripcion")]
        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }


        public List<Arbol> Arboles { get; set; }       
        public List<EspecieArbol> EspeciesArboles { get; set; }
    }
}
