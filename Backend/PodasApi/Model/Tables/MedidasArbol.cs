using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{

    [Table("medidas_arbol")]
    public class MedidasArbol : Auditoria
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("id_arbol")]
        [Required]
        public int IdArbol { get; set; }        

        [Column("id_tipo_emplazamiento")]
        [Required]
        public int IdTipoEmplazamiento { get; set; }        

        [Column("altura")]
        [Required]
        public float Altura { get; set; }

        [Column("altura_fus")]
        [Required]
        public float AlturaFus { get; set; }

        [Column("diametro_c")]
        [Required]
        public float DiametroC { get; set; }

        [Column("diametro_n")]
        [Required]
        public float DiametroN { get; set; }

        [Column("volumen")]
        [Required]
        public float Volumen { get; set; }

        public Arbol Arbol { get; set; }
        public TipoEmplazamiento TipoEmplazamiento { get; set; }
    }
}
