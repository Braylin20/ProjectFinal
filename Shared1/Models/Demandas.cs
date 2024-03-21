using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Demandas
    {
        [Key]
        public int DemandaId { get; set; }
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Descripcion { get; set; }
        //[ForeignKey("EstadosDemandas")]
        //public int EstadoId { get; set; }
        //[ForeignKey("Cedula")]
        //public ICollection<Usuarios> Usuarios { get; set; } = new List<Usuarios>();
        //[ForeignKey("DemandadoId")]
        //public ICollection<Demandados> Demandados { get; set; } = new List<Demandados>();
        //[ForeignKey("Id")]
        //public ICollection<TiposDemandas> TiposDemandas { get; set; } = new List<TiposDemandas>();
        //[ForeignKey("AudienciaId")]
        //public ICollection<Audiencias> Audiencias { get; set; } = new List<Audiencias>();

    }
}
