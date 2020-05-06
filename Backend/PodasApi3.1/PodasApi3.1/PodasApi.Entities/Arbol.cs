using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("arboles")]
    public class Arbol
    {
        [Key]                
        [Required]
        public int Id { get; set; }
        
        [Required]
        public int MunicipioId { get; set; }
                
        [Required]
        public int LocalidadId { get; set; }
        
        [Required]
        public int BarrioId { get; set; }
                
        public int? Codigo1 { get; set; }
        
        [StringLength(20)]
        public string Codigo2 { get; set; }

        [Required]
        public int FamiliaArbolId { get; set; }
        
        [Required]
        public int EspecieArbolId { get; set; }
                
        [Required]
        public int CategoriaArbolId { get; set; }
        
        [Required]
        public float Altura { get; set; }

        [Required]
        public double Latitud { get; set; }
       
        [Required]
        public double Longitud { get; set; }
        
        [Required]
        public int TipoEmplazamientoId { get; set; }

        
        public string Estado { get; set; }

        public Estados getEstado()
        {
            return ConvertirEstados.ConvertirEstado(this.Estado);
        }

        public void setEstado(Estados estado)
        {
            this.Estado = ConvertirEstados.ConvertirEstado(estado);
        }

        [StringLength(20)]
        [Required]
        public string UsuarioCreacion { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        [StringLength(20)]
        public string UsuarioModificacion { get; set; }

        public DateTime FechaModificacion { get; set; }



        [ForeignKey("MunicipioId")]
        public virtual Municipio Municipio { get; set; }

        [ForeignKey("LocalidadId")]
        public virtual Localidad Localidad { get; set; }

        [ForeignKey("BarrioId")]
        public virtual Barrio Barrio { get; set; }

        [ForeignKey("FamiliaArbolId")]
        public virtual FamiliaArbol FamiliaArbol { get; set; }

        [ForeignKey("EspecieArbolId")]
        public virtual EspecieArbol EspecieArbol { get; set; }

        [ForeignKey("CategoriaArbolId")]
        public virtual CategoriaArbol CategoriaArbol { get; set; }

        [ForeignKey("TipoEmplazamientoId")]
        public virtual TipoEmplazamiento TipoEmplazamiento { get; set; }


        [InverseProperty("Arbol")]
        public virtual List<CambioEstado> CambiosEstado { get; set; }

        [InverseProperty("Arbol")]
        public virtual List<ConflictoArbol> ConflictosArbol { get; set; }

        [InverseProperty("Arbol")]
        public virtual List<DetalleAsignacion> DetalleAsignaciones { get; set; }

        [InverseProperty("Arbol")]
        public virtual List<DetalleRechazos> DetalleRechazos { get; set; }

        [InverseProperty("Arbol")]
        public virtual List<MedidasArbol> MedidasArbol { get; set; }

        [InverseProperty("Arbol")]
        public virtual List<RiesgoArbol> RiesgoArbol { get; set; }


    }
}
