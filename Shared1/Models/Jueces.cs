using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Jueces
    {
        [Key]
        public int JuezId { get; set; }
        public int SentenciaId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Nombre { get; set; }
    }
}
