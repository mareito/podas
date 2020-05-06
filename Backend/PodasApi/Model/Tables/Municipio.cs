using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("municipios")]
    public class Municipio : Auditoria
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("nombre")]
        [Required]
        public string Nombre { get; set; }

        [Column("id_departamento")]
        [Required]
        public int IdDepartamento { get; set; }
        
        [Column("codigo_dane")]
        [Required]
        public string CodigoDane { get; set; }
        
        public Departamento Departamento { get; set; }

        
        public List<Asignacion> Asignaciones { get; set; }
        
        public List<Arbol> Arboles { get; set; }
        
        public List<Barrio> Barrios { get; set; }
        
        public List<Localidad> Localidades { get; set; }
        
        public List<TarifaPoda> TarifasPodas { get; set; }
        
        public List<Tercero> Terceros { get; set; }


    }
}
