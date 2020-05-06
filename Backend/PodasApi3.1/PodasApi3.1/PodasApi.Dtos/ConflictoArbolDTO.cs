using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class ConflictoArbolDTO
    {
        public int Id { get; set; }
        public int ArbolId { get; set; }
        public bool RedesElectricas { get; set; }
        public bool RedesHidraulicas { get; set; }
        public bool OtrosArboles { get; set; }
        public bool Estructuras { get; set; }
        public bool InfraestructuraVial { get; set; }
        public bool RedesTelefonicas { get; set; }
        public bool RedesGas { get; set; }
        public bool Alumbrado { get; set; }
        public string Estado { get; set; }
        public Estados getEstado()
        {
            return ConvertirEstadosDTO.ConvertirEstado(this.Estado);
        }
        public void setEstado(Estados estado)
        {
            this.Estado = ConvertirEstadosDTO.ConvertirEstado(estado);
        }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public ArbolDTO Arbol { get; set; }

    }
}
