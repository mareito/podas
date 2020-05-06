using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{

    [Table("riesgo_arbol")]
    public class RiesgoArbol
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int ArbolId { get; set; }
           
        [Required]
        public bool Volcamiento { get; set; }

        [Required]
        public bool Ramas { get; set; }

        [Required]
        public bool CaidaElementos { get; set; }

        
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
    }
}
