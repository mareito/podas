using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class RiesgoArbol : Auditoria
    {
        public int Id { get; set; }
        public int IdArbol { get; set; }
        public bool Volcamiento { get; set; }
        public bool Ramas { get; set; }
        public bool CaidaElementos { get; set; }
    }
}
