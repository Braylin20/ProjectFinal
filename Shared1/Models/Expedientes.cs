using Shared1.Detalles;
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
        public int UsuarioId { get; set; }
        
        
        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime FechaEntrada { get; set; }

        [ForeignKey("ExpedienteId")]
        public ICollection<ExpedientesDetalles> ExpedientesDetalles { get; set; } = new List<ExpedientesDetalles>();

    }
}
