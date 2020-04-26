using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class MedidasArbol : Auditoria
    {
        public int Id { get; set; }
        public int IdArbol { get; set; }
        public int IdEmplazamiento { get; set; }
        public float Altura { get; set; }
        public float AlturaFus { get; set; }
        public float DiametroC { get; set; }
        public float DiametroN { get; set; }
        public float Volumen { get; set; }
    }
}
