using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities.Tables
{
    class TipoIntervencion : Auditoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
