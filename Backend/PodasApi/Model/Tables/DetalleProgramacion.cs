using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class DetalleProgramacion: Auditoria
    {
        public int Id { get; set; }
        public int IdProgramacion { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
    }
}
