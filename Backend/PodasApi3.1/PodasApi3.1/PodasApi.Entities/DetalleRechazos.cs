using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("detalle_rechazos")]
    public class DetalleRechazos
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int ArbolId { get; set; }
        
        [Required]
        public int TerceroId { get; set; }
       
        [Required]
        public DateTime FechaNovedad { get; set; }

        [Required]
        [StringLength(100)]
        public string Observacion { get; set; }

        [Required]
        public bool Corregir { get; set; }

        [Required]
        public bool Inactivar { get; set; }

        
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
        public Tercero Tercero { get; set; }
    }
}
