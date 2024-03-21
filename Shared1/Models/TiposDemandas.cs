using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class TiposDemandas
    {
        [Key]
        public int Id { get; set; }
        public int DemandaId { get; set; }
        public string? NombreDemanda { get; set; }
    }
}
