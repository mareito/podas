using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class CategoriaArbol : Auditoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string AlturaMinima { get; set; }
        public string AlturaMaxima { get; set; }
        
    }
}
