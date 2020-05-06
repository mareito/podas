using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PodasApi.Entities.Tables
{
    [Table("conflicto_arbol")]
    public class ConflictoArbol
    {
        [Key]        
        [Required]
        public int Id { get; set; }

        [Required]
        public int ArbolId { get; set; }
       
        [Required]
        public bool RedesElectricas { get; set; }
        
        [Required]
        public bool RedesHidraulicas { get; set; }

        [Required]
        public bool OtrosArboles { get; set; }

        [Required]
        public bool Estructuras { get; set; }

        [Required]
        public bool InfraestructuraVial { get; set; }

        [Required]
        public bool RedesTelefonicas { get; set; }

        [Required]
        public bool RedesGas { get; set; }

        [Required]
        public bool Alumbrado { get; set; }

        
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

        [ForeignKey("ArbolId")]
        public Arbol Arbol { get; set; }
    }
}
