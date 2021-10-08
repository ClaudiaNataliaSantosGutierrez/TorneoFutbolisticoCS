
using System.Collections.Generic;

namespace TorneoFutbolistico.App.Dominio
{
      
    public class Partido
    {
        public int Id { get; set; } 
        [Required(ErrorMessage = "La Fecha/Hora es obligatoria")]
        public string FechaHora  { get; set; }
        [Required(ErrorMessage = "El Equipo local es obligatorio")]
        public string EquipoLocal { get; set; }
        public int MarcadorLocal { get; set; }
        [Required(ErrorMessage = "El equipo Visitante es obligatorio")]
        public string EquipoVisitante { get; set; }
        public int MarcadorVisitante { get; set; }
        public Estadio Estadio { get; set; }
        public Arbitro Arbitro { get; set; }
    }
}
