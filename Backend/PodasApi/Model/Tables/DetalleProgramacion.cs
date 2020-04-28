using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("detalle_programacion")]
    public class DetalleProgramacion: Auditoria
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("id_programacion_poda")]
        [Required]
        public int IdProgramacionPoda { get; set; }        

        [Column("descripcion")]
        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }

        [Column("fecha_inicial")]
        [Required]
        public DateTime FechaInicial { get; set; }

        [Column("fecha_final")]
        [Required]
        public DateTime FechaFinal { get; set; }



        public ProgramacionPoda ProgramacionPoda { get; set; }

        List<Asignacion> Asignaciones { get; set; }
    }
}
