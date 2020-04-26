using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities.Tables
{
    class ConflictoArbol : Auditoria
    {
        public int Id { get; set; }
        public int IdArbol { get; set; }
        public bool RedesElectricas { get; set; }
        public bool RedesHidraulicas { get; set; }
        public bool OtrosArboles { get; set; }
        public bool Estructuras { get; set; }
        public bool InfraestructuraVial { get; set; }
        public bool RedesTelefonicas { get; set; }
        public bool RedesGas { get; set; }
        public bool Alumbrado { get; set; }
    }
}
