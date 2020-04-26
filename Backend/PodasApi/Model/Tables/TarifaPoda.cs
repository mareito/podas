using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class TarifaPoda : Auditoria
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public int IdMunicipio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Valor { get; set; }
    }
}
