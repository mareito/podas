using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{

    [Table("medidas_arbol")]
    public class MedidasArbol
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int ArbolId { get; set; }        

        [Required]
        public int TipoEmplazamientoId { get; set; }        

        [Required]
        public float Altura { get; set; }

        [Required]
        public float AlturaFus { get; set; }

        [Required]
        public float DiametroC { get; set; }

        [Required]
        public float DiametroN { get; set; }

        [Required]
        public float Volumen { get; set; }

        
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

        public Arbol Arbol { get; set; }
        public TipoEmplazamiento TipoEmplazamiento { get; set; }
    }
}
