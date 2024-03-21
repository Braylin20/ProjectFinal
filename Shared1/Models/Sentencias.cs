using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Sentencias
    {
        [Key]
        public int SentenciaId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime FechaCreacion { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? NombreMinisterio { get; set; }
        //[Required(ErrorMessage = "Este campo es obligatorio")]
        //[ForeignKey("SentenciaId")]
        //public ICollection<Expedientes> Expedientes { get; set; } = new List<Expedientes>();
        //[ForeignKey("SentenciaId")]
        //public ICollection<Usuarios> Usuarios { get; set; } = new List<Usuarios>();
        [ForeignKey("SentenciaId")]
        public ICollection<Demandas> Demandas { get; set; } = new List<Demandas>();
        [ForeignKey("SentenciaId")]
        public ICollection<Jueces> Jueces { get; set; } = new List<Jueces>(); //Deberian ser jueces o un solo juez???
        //[ForeignKey("TipoResoluciones")]
        //public int ResolucionId { get; set; }

    }
}
