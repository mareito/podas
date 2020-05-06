
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PodasApi.Entities.Tables
{
    public class Auditoria
    {  
        
        [Required]
        private string estado;
        
        public Estados getEstado()
        {
            return ConvertirEstados.ConvertirEstado(this.estado);
        }

        public void setEstado(Estados estado)
        {
            this.estado = ConvertirEstados.ConvertirEstado(estado);
        }
        
        [StringLength(20)]
        [Required]
        public string UsuarioCreacion { get; set; }
        
        [Required]
        public DateTime FechaCreacion { get; set; }

        [StringLength(20)]
        public string UsuarioModificacion { get; set; }

        public DateTime FechaModificacion { get; set; }
    }
}
