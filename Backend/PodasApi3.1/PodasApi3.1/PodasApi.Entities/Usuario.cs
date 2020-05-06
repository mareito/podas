using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("usuarios")]
    public class Usuario
    {

        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string login { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Correo { get; set; }

        [Required]
        [StringLength(1)]
        public string TipoIdentificacion { get; set; }

        [Required]
        public double NumeroIdentificacion { get; set; }

        [Required]
        [StringLength(20)]
        public string Telefono1 { get; set; }

        [Required]
        [StringLength(20)]
        public string Telefono2 { get; set; }

        [Required]
        [StringLength(1)]
        public string TipoUsuario { get; set; }

        [Required]
        public int TerceroId { get; set; }

        [Required]
        public byte[] Pasword { get; set; }

        [Required]
        public byte[] Salt { get; set; }

        [Required]
        public bool CambioClave { get; set; }

        [Required]
        public bool CorreoConfirmado { get; set; }


        
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


        public Tercero Tercero { get; set; }

    }
}
