using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PodasApi.Entities.Tables
{
    [Table("barrios")]
    public class Barrio
    {
        [Key]        
        [Required]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        public int MunicipioId { get; set; }
        
        [Required]
        public int LocalidadId { get; set; }

        
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

        public virtual Municipio Municipio { get; set; }
        
        public virtual Localidad Localidad { get; set; }

        public virtual List<Asignacion> Asignaciones { get; set; }
        public virtual List<Arbol> Arboles { get; set; }
    }
}
