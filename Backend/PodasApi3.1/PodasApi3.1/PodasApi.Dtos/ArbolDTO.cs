using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{   
    public class ArbolDTO
    {
        public int Id { get; set; }
        public int MunicipioId { get; set; }
        public int LocalidadId { get; set; }
        public int BarrioId { get; set; }
        public int? Codigo1 { get; set; }
        public string Codigo2 { get; set; }
        public int FamiliaArbolId { get; set; }
        public int EspecieArbolId { get; set; }
        public int CategoriaArbolId { get; set; }
        public float Altura { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public int TipoEmplazamientoId { get; set; }
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

        public virtual MunicipioDTO Municipio { get; set; }
        public virtual LocalidadDTO Localidad { get; set; }
        public virtual BarrioDTO Barrio { get; set; }
        public virtual FamiliaArbolDTO FamiliaArbol { get; set; }
        public virtual EspecieArbolDTO EspecieArbol { get; set; }
        public virtual CategoriaArbolDTO CategoriaArbol { get; set; }
        public virtual TipoEmplazamiento TipoEmplazamiento { get; set; }
        public virtual List<CambioEstadoDTO> CambiosEstado { get; set; }
        public virtual List<ConflictoArbolDTO> ConflictosArbol { get; set; }
        public virtual List<DetalleAsignacionDTO> DetalleAsignaciones { get; set; }
        public virtual List<DetalleRechazosDTO> DetalleRechazos { get; set; }
        public virtual List<MedidasArbolDTO> MedidasArbol { get; set; }
        public virtual List<RiesgoArbolDTO> RiesgoArbol { get; set; }


    }
}
