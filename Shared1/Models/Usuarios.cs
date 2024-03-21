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
        public int DemandaId { get; set; }
        public int SentenciaId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int Cedula { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Nombre { get; set; }
        [EmailAddress(ErrorMessage = "Este campo es requerido")]
        public string? Correo { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Clave { get; set; }
        public DateTime FechaCreacion { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public long Telefono { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Rol { get; set; }

        [ForeignKey("UsuarioId")]
        public ICollection<Niños> Niños { get; set; } = new List<Niños>();
        [ForeignKey("UsuarioId")]
        public ICollection<Expedientes> Expedientes { get; set; } = new List<Expedientes>();
        [ForeignKey("UsuarioId")]
        public ICollection<Demandas> Demandas { get; set; } = new List<Demandas>();
        [ForeignKey("UsuarioId")]
        public ICollection<Abogados> Abogados { get; set; } = new List<Abogados>();
    }
}
