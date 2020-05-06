using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class TarifaPodaDTO
    {
        public int Id { get; set; }
        public int CategoriaArbolId { get; set; }
        public int MunicipioId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Valor { get; set; }
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
        public CategoriaArbolDTO CategoriaArbol { get; set; }
        public MunicipioDTO Municipio { get; set; }
    }
}
