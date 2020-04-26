using System;
using System.Collections.Generic;
using System.Text;

namespace PodasApi.Entities.Tables
{
    public class Usuario : Auditoria
    {
        public int Id { get; set; }
        public string login { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string TipoIdentificacion { get; set; }
        public int NumeroIdentificacion { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string TipoUsuario { get; set; }
        public string IdTerceroLabora { get; set; }
        public byte[] Pasword { get; set; }
        public byte[] Salt { get; set; }
        public bool CambioClave { get; set; }
        public bool CorreoConfirmado { get; set; }

    }
}
