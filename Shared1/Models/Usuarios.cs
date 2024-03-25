using Shared1.Detalles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int Cedula { get; set; }
        public int RolId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Nombre { get; set; }
        [EmailAddress(ErrorMessage = "Este campo es requerido")]
        public string? Correo { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Clave { get; set; }
        public DateTime FechaCreacion { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public long Telefono { get; set; }
        [ForeignKey("RolId")]
        public Roles? Roles { get; set; }

        [ForeignKey("UsuarioId")]
        public ICollection<Expedientes> Expedientes { get; set; } = new List<Expedientes>();
        [ForeignKey("UsuarioId")]
        public ICollection<Niños> Niños { get; set; } = new List<Niños>();
        [ForeignKey("UsuarioId")]
        public ICollection<Abogados> Abogados { get; set; } = new List<Abogados>();
    }
}
