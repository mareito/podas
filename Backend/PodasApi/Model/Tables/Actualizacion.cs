using PodasApi.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities
{
    public class Actualizacion : Auditoria
    {
        public int Id { get; set; }
        public string NombreTabla { get; set; }
        public int Version { get; set; }
    }
}
