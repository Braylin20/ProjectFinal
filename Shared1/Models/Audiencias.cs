using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Audiencias
    {
        [Key]
        public int AudienciaId { get; set; }
        public int DemandaId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime FechaAudiencia { get; set; }
        //[ForeignKey("AlguacilId")]
        //public ICollection<Alguaciles> Alguaciles { get; set; } = new List<Alguaciles>();

    }
}
