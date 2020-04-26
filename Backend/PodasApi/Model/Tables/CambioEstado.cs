using PodasApi.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class CambioEstado : Auditoria
    {
        public int Id { get; set; }
        public int IdArbol { get; set; }
        private string estadoAnterior;
        public Estados getEstadoAnterior()
        {
            return ConvertirEstados.ConvertirEstado(this.estadoAnterior);
        }

        public void setEstadoAnterior(Estados estadoAnterior)
        {
            this.estadoAnterior = ConvertirEstados.ConvertirEstado(estadoAnterior);
        }
       
        private string estadoActual;
        public Estados getEstadoActual()
        {
            return ConvertirEstados.ConvertirEstado(this.estadoActual);
        }
        public void setEstadoActual(Estados estadoActual)
        {
            this.estadoActual = ConvertirEstados.ConvertirEstado(estadoActual);
        }
        
        public string Observacion { get; set; }

    }
}
