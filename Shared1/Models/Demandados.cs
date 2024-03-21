using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Demandados
    {
        [Key]
        public int DemandadoId { get; set; }
        public string? Cedula { get; set; }
        public string? nombre { get; set; }
    }
}
