using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Expedientes
    {
        [Key]
        public int ExpedienteId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Comentario { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime FechaEntrada { get; set; }
        [ForeignKey("Cedula")]
        public ICollection<Usuarios> Usuarios { get; set; } = new List<Usuarios>();
        [ForeignKey("DemandaId")]
        public ICollection<Demandas> Demandas { get; set; } = new List<Demandas>();
    }
}
