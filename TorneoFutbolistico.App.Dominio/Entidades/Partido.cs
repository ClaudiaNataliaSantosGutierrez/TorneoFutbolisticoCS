
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

namespace TorneoFutbolistico.App.Dominio
{
      
    public class Partido
    {
        public int Id { get; set; } 
        [Required(ErrorMessage = "La fecha es obligatoria")]
        public string FechaHora  { get; set; }
        public string EquipoLocal { get; set; }
        [Required(ErrorMessage = "El MarcadorLocal es obligatorio")]
        public int MarcadorLocal { get; set; }
        public string EquipoVisitante { get; set; }
        [Required(ErrorMessage = "El MarcadorVisitante es obligatorio")]
        public int MarcadorVisitante { get; set; }
        public Estadio Estadio { get; set; }
        public Arbitro Arbitro { get; set; }
    }
}