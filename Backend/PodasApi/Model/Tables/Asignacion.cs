using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class Asignacion
    {
        public int Id { get; set; }
        public int IdProgramacion { get; set; }
        public int IdDetalleProgramacion { get; set; }
        public int IdMunicipio { get; set; }
        public int IdLocalidad { get; set; }
        public int IdBarrio { get; set; }
        public int IdContratista { get; set; }
        public int IdCuadrilla { get; set; }
        public int TotalCensadoInicial { get; set; }
        public int TotalNoCensadoInicial { get; set; }
        public int TotalCensadoFinal { get; set; }
        public int TotalNoCensadoFinal { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
