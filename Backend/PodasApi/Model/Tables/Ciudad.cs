using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class Ciudad : Auditoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdDepartamento { get; set; }
        public string CodigoDane { get; set; }
    }
}
