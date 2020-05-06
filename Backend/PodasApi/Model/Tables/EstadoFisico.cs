using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{

    [Table("estado_fisico")]
    public class EstadoFisico : Auditoria
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("descripcion")]
        [Required]
        [StringLength(50)]
        public int Descripcion { get; set; }
        
        public List<DetalleAsignacion> DetalleAsignacionesIniciales { get; set; }
    }
}
