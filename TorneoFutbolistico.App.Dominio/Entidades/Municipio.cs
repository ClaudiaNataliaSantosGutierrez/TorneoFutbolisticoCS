using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

namespace TorneoFutbolistico.App.Dominio
{
      
    public class Municipio
    {
        public int Id { get; set; } 
        [Required(ErrorMessage = "El nombre del Municipio es obligatorio")]
        public string NombreMunicipio { get; set; }
        public Equipo Equipo { get; set; }
        ///public Estadio Estadio { get; set; }
    }
}