using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace TorneoFutbolistico.App.Dominio
{
      
    public class Equipo
    {
        public int Id { get; set; } 
        [Display(Name = "Nombre del Equipo")]
        public string NombreEquipo { get; set; } 
        //public DirectorTecnico DirectorTecnico { get; set; }
        public Desempeño Desempeño { get; set; }
        ///public Jugador Jugador { get; set; }
        //public Municipio Municipio { get; set; }
    }
}