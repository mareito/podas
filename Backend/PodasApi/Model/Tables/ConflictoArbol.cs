using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("conflicto_arbol")]
    public class ConflictoArbol : Auditoria
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("id_arbol")]
        [Required]
        public int IdArbol { get; set; }
       
        [Column("redes_electricas")]
        [Required]
        public bool RedesElectricas { get; set; }

        [Column("redes_hidraulicas")]
        [Required]
        public bool RedesHidraulicas { get; set; }

        [Column("otros_arboles")]
        [Required]
        public bool OtrosArboles { get; set; }

        [Column("estructuras")]
        [Required]
        public bool Estructuras { get; set; }

        [Column("infraestructura_vial")]
        [Required]
        public bool InfraestructuraVial { get; set; }

        [Column("redes_telefonicas")]
        [Required]
        public bool RedesTelefonicas { get; set; }

        [Column("redes_gas")]
        [Required]
        public bool RedesGas { get; set; }

        [Column("alumbrado")]
        [Required]
        public bool Alumbrado { get; set; }

        public Arbol Arbol { get; set; }
    }
}
