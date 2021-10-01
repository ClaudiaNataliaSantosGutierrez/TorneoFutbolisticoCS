using System.Collections.Generic;

namespace TorneoFutbolistico.App.Dominio
{
      
    public class Equipo
    {
        public int Id { get; set; } 
        public string NombreEquipo { get; set; } 
        //public DirectorTecnico DirectorTecnico { get; set; }
        public Desempeño Desempeño { get; set; }
        ///public Jugador Jugador { get; set; }
        //public Municipio Municipio { get; set; }
    }
}