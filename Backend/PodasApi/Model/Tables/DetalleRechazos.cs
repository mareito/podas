using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class DetalleRechazos
    {
        public int Id { get; set; }
        public int IdArbol { get; set; }
        public int IdTercero { get; set; }
        public DateTime FechaNovedad { get; set; }
        public string Observacion { get; set; }
        public bool Corregir { get; set; }
        public bool Inactivar { get; set; }
    }
}
