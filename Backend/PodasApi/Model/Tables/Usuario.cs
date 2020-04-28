using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("usuarios")]
    public class Usuario : Auditoria
    {

        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("login")]
        [Required]
        [StringLength(20)]
        public string login { get; set; }

        [Column("nombre")]
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Column("correo")]
        [Required]
        [StringLength(100)]
        public string Correo { get; set; }

        [Column("tipo_identificacion")]
        [Required]
        [StringLength(1)]
        public string TipoIdentificacion { get; set; }

        [Column("numero_identificacion")]
        [Required]
        public double NumeroIdentificacion { get; set; }

        [Column("telefono1")]
        [Required]
        [StringLength(20)]
        public string Telefono1 { get; set; }

        [Column("telefono2")]
        [Required]
        [StringLength(20)]
        public string Telefono2 { get; set; }

        [Column("tipo_usuario")]
        [Required]
        [StringLength(1)]
        public string TipoUsuario { get; set; }

        [Column("id_tercero")]
        [Required]
        public string IdTercero { get; set; }

        [Column("password")]
        [Required]
        public byte[] Pasword { get; set; }

        [Column("salt")]
        [Required]
        public byte[] Salt { get; set; }

        [Column("cambiar_clave")]
        [Required]
        public bool CambioClave { get; set; }

        [Column("correo_confirmado")]
        [Required]
        public bool CorreoConfirmado { get; set; }

        public Tercero Tercero { get; set; }

    }
}
