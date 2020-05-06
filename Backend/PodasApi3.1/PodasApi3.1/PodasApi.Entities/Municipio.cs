using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("municipios")]
    public class Municipio
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public int DepartamentoId { get; set; }
        
        [Required]
        public string CodigoDane { get; set; }

        
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

        
        public List<Asignacion> Asignaciones { get; set; }
        
        public List<Arbol> Arboles { get; set; }
        
        public List<Barrio> Barrios { get; set; }
        
        public List<Localidad> Localidades { get; set; }
        
        public List<TarifaPoda> TarifasPodas { get; set; }
        
        public List<Tercero> Terceros { get; set; }


    }
}
