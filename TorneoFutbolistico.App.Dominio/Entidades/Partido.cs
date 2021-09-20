
using System.Collections.Generic;

namespace TorneoFutbolistico.App.Dominio
{
      
    public class Partido
    {
        public int Id { get; set; } 
        public string FechaHora  { get; set; }
        public string EquipoLocal { get; set; }
        public int MarcadorLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public int MarcadorVisitante { get; set; }
        public Estadio Estadio { get; set; }
        public Arbitro Arbitro { get; set; }
    }
}