using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class Arbol : Auditoria
    {
        public int Id { get; set; }
        public int IdMunicipio { get; set; }
        public int IdLocalidad { get; set; }
        public int IdBarrio { get; set; }
        public int Codigo1 { get; set; }
        public string Codigo2 { get; set; }
        public int IdFamilia { get; set; }
        public int IdEspecie { get; set; }
        public int IdCategoria { get; set; }
        public float Altura { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public int IdTipoEmplazamiento { get; set; }

    }
}
