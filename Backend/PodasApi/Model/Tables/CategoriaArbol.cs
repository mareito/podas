using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("categoria_arbol")]
    public class CategoriaArbol : Auditoria
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("descripcion")]
        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [Column("altura_minima")]
        [Required]
        public string AlturaMinima { get; set; }

        [Column("altura_maxima")]
        [Required]
        public string AlturaMaxima { get; set; }

        public List<Arbol> Arboles { get; set; }

        [InverseProperty("CategoriaInicial")]
        public List<DetalleAsignacion> DetalleAsignacionesIniciales { get; set; }
        [InverseProperty("CategoriaFinal")]
        public List<DetalleAsignacion> DetalleAsignacionesFinales { get; set; }
        public List<TarifaPoda> TarifasPodas { get; set; }

    }
}
