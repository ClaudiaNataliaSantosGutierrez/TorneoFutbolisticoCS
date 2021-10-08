using System.Collections.Generic;

namespace TorneoFutbolistico.App.Dominio
{
      
    public class Municipio
    {
        public int Id { get; set; } 
        [Required(ErrorMessage = "El Nombre de Municipio es obligatorio")]
        public string NombreMunicipio { get; set; }
        public Equipo Equipo { get; set; }
        ///public Estadio Estadio { get; set; }
    }
}
