using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("programacion_poda")]
    public class ProgramacionPoda : Auditoria
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("observacion")]
        [Required]
        public string Observacion { get; set; }

        [Column("fecha_inicio")]
        [Required]
        public DateTime FechaInicio { get; set; }

        [Column("fecha_fin")]
        [Required]
        public DateTime FechaFin { get; set; }

        public List<Asignacion> Asignaciones { get; set; }
        public List<DetalleProgramacion> DetalleProgramaciones { get; set; }
    }
}
