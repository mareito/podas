using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{

    [Table("tipo_novedad")]
    public class TipoNovedadPoda
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        
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

        public List<DetalleAsignacion> DetalleAsignacionesIniciales { get; set; }
    }
}
