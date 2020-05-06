using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{

    public class MedidasArbolDTO
    {
        public int Id { get; set; }
        public int ArbolId { get; set; }        
        public int TipoEmplazamientoId { get; set; }        
        public float Altura { get; set; }
        public float AlturaFus { get; set; }
        public float DiametroC { get; set; }
        public float DiametroN { get; set; }
        public float Volumen { get; set; }
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
        public TipoEmplazamientoDTO TipoEmplazamiento { get; set; }
    }
}
