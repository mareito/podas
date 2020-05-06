using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("detalle_programacion")]
    public class DetalleProgramacion
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int ProgramacionPodaId { get; set; }        

        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }

        [Required]
        public DateTime FechaInicial { get; set; }

        [Required]
        public DateTime FechaFinal { get; set; }

        
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



        public ProgramacionPoda ProgramacionPoda { get; set; }

        public List<Asignacion> Asignaciones { get; set; }
    }
}
