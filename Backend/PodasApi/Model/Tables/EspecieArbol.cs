using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class EspecieArbol : Auditoria
    {
        public int Id { get; set; }
        public string NombreComun { get; set; }
        public string NombreCientifico { get; set; }
        public int IdFamilia { get; set; }
    }
}
