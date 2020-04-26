using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class Tercero : Auditoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Contacto { get; set; }
        public string Direccion { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }    
        public string IdDepartamento { get; set; }
        public string IdMunicipio { get; set; }
    }
}
