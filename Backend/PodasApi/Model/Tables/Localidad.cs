using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class Localidad : Auditoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdMunicipio { get; set; }        
    }
}
