using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("tarifa_poda")]
    public class TarifaPoda : Auditoria
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("id_categoria_arbol")]
        [Required]
        public int IdCategoriaArbol { get; set; }
        
        [Column("id_municipio")]
        [Required]
        public int IdMunicipio { get; set; }
        
        [Column("fecha_inicio")]
        [Required]
        public DateTime FechaInicio { get; set; }

        [Column("fecha_fin")]
        [Required]
        public DateTime FechaFin { get; set; }

        [Column("valor")]
        [Required]
        public decimal Valor { get; set; }


        public CategoriaArbol CategoriaArbol { get; set; }
        public Municipio Municipio { get; set; }
    }
}
