using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{

    [Table("riesgo_arbol")]
    public class RiesgoArbol : Auditoria
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("id_arbol")]
        [Required]
        public int IdArbol { get; set; }
           
        [Column("volcamiento")]
        [Required]
        public bool Volcamiento { get; set; }

        [Column("ramas")]
        [Required]
        public bool Ramas { get; set; }

        [Column("caida_elementos")]
        [Required]
        public bool CaidaElementos { get; set; }


        public Arbol Arbol { get; set; }
    }
}
