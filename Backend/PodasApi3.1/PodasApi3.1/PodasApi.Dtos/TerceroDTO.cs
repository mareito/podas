using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class TerceroDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoIdentificacion { get; set; }
        public double NumeroIdentificacion { get; set; }
        public string Contacto { get; set; }
        public string Direccion { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public int DepartamentoId { get; set; }
        public int MunicipioId { get; set; }
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
        public DepartamentoDTO Departamento { get; set; }
        public MunicipioDTO Municipio { get; set; }
        public List<AsignacionDTO> Asignaciones { get; set; }
        public List<CuadrillaDTO> Cuadrillas { get; set; }
        public List<DetalleAsignacionDTO> DetalleAsignaciones { get; set; }
        public List<DetalleRechazosDTO> DetalleRechazos { get; set; }
        public List<UsuarioDTO> Usuarios { get; set; }
    }
}
