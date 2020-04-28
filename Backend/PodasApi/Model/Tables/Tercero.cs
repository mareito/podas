using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("terceros")]
    public class Tercero : Auditoria
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("nombre")]
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Column("tipo_identificacion")]
        [Required]
        [StringLength(1)]
        public string TipoIdentificacion { get; set; }

        [Column("numero_identificacion")]
        [Required]
        public double NumeroIdentificacion { get; set; }

        [Column("contacto")]        
        [StringLength(100)]
        public string Contacto { get; set; }

        [Column("direccion")]
        [Required]
        [StringLength(100)]
        public string Direccion { get; set; }

        [Column("telefono1")]        
        [StringLength(20)]
        public string Telefono1 { get; set; }

        [Column("telefono2")]        
        [StringLength(20)]
        public string Telefono2 { get; set; }

        [Column("id_departamento")]
        [Required]
        public string IdDepartamento { get; set; }

        [Column("id_municipio")]
        [Required]
        public string IdMunicipio { get; set; }


        public Departamento Departamento { get; set; }
        public Municipio Municipio { get; set; }


        public List<Asignacion> Asignaciones { get; set; }
        public List<Cuadrilla> Cuadrillas { get; set; }
        public List<DetalleAsignacion> DetalleAsignaciones { get; set; }
        public List<DetalleRechazos> DetalleRechazos { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}
