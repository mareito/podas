using PodasApi.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class Auditoria
    {
        private string estado;
        public Estados getEstado()
        {
            return ConvertirEstados.ConvertirEstado(this.estado);
        }

        public void setEstado(Estados estado)
        {
            this.estado = ConvertirEstados.ConvertirEstado(estado);
        }

        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
