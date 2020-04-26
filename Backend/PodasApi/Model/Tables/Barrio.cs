using PodasApi.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class Barrio : Auditoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdMunicipio { get; set; }
        public int IdLocalidad { get; set; }       
    }
}
