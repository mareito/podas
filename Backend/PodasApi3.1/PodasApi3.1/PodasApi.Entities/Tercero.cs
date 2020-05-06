using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("terceros")]
    public class Tercero
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(1)]
        public string TipoIdentificacion { get; set; }

        [Required]
        public double NumeroIdentificacion { get; set; }

        [StringLength(100)]
        public string Contacto { get; set; }

        [Required]
        [StringLength(100)]
        public string Direccion { get; set; }

        [StringLength(20)]
        public string Telefono1 { get; set; }

        [StringLength(20)]
        public string Telefono2 { get; set; }

        [Required]
        public int DepartamentoId { get; set; }

        [Required]
        public int MunicipioId { get; set; }

        
        public string Estado { get; set; }

        public Estados getEstado()
        {
            return ConvertirEstados.ConvertirEstado(this.Estado);
        }

        public void setEstado(Estados estado)
        {
            this.Estado = ConvertirEstados.ConvertirEstado(estado);
        }

        [StringLength(20)]
        [Required]
        public string UsuarioCreacion { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        [StringLength(20)]
        public string UsuarioModificacion { get; set; }

        public DateTime FechaModificacion { get; set; }


        public Departamento Departamento { get; set; }
        public Municipio Municipio { get; set; }


        public List<Asignacion> Asignaciones { get; set; }
        public List<Cuadrilla> Cuadrillas { get; set; }
        public List<DetalleAsignacion> DetalleAsignaciones { get; set; }
        public List<DetalleRechazos> DetalleRechazos { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}
