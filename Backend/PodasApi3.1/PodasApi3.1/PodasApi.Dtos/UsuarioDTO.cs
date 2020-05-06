using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string login { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string TipoIdentificacion { get; set; }
        public double NumeroIdentificacion { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string TipoUsuario { get; set; }
        public int TerceroId { get; set; }
        public byte[] Pasword { get; set; }
        public byte[] Salt { get; set; }
        public bool CambioClave { get; set; }
        public bool CorreoConfirmado { get; set; }
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
        public TerceroDTO Tercero { get; set; }

    }
}
