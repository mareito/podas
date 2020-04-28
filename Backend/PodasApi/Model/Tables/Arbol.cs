using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("arboles")]
    public class Arbol : Auditoria
    {
        [Key]        
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("id_municipio")]
        [Required]
        public int IdMunicipio { get; set; }
        
        [Column("id_localidad")]
        [Required]
        public int IdLocalidad { get; set; }
        
        [Column("id_barrio")]
        [Required]
        public int IdBarrio { get; set; }
        
        [Column("codigo1")]        
        public int? Codigo1 { get; set; }

        [Column("codigo2", TypeName = "varchar(20)")]
        [StringLength(20)]
        public string Codigo2 { get; set; }

        [Column("id_familia_arbol")]
        [Required]
        public int IdFamiliaArbol { get; set; }
        
        [Column("id_especie_arbol")]
        [Required]
        public int IdEspecieArbol { get; set; }
        
        [Column("id_categoria_arbol")]
        [Required]
        public int IdCategoriaArbol { get; set; }
        
        [Column("altura")]
        [Required]
        public float Altura { get; set; }

        [Column("latitud")]
        [Required]
        public double Latitud { get; set; }

        [Column("longitud")]
        [Required]
        public double Longitud { get; set; }

        [Column("id_tipo_emplazamiento")]
        [Required]
        public int IdTipoEmplazamiento { get; set; }
        

        public Municipio Municipio { get; set; }
        public Localidad Localidad { get; set; }
        public Barrio Barrio { get; set; }
        public FamiliaArbol FamiliaArbol { get; set; }
        public EspecieArbol EspecieArbol { get; set; }
        public CategoriaArbol CategoriaArbol { get; set; }
        public TipoEmplazamiento TipoEmplazamiento { get; set; }


        public List<CambioEstado> CambiosEstado { get; set; }
        public List<ConflictoArbol> ConflictosArbol { get; set; }
        public List<DetalleAsignacion> DetalleAsignaciones { get; set; }
        public List<DetalleRechazos> DetalleRechazos { get; set; }
        public List<MedidasArbol> MedidasArbol { get; set; }
        public List<RiesgoArbol> RiesgoArbol { get; set; }


    }
}
