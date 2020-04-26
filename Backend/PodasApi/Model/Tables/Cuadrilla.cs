using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class Cuadrilla : Auditoria
    {
        public int Id { get; set; }
        public int Descripcion { get; set; }
        public int IdTercero { get; set; }
    }
}
