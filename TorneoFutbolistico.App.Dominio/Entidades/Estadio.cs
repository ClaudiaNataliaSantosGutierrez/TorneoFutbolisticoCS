using System.ComponentModel.DataAnnotations;
namespace TorneoFutbolistico.App.Dominio
{
      
    public class Estadio
    {
        public int Id { get; set; } 
        [Required(ErrorMessage = "El NombreEstadio es obligatorio")]
        public string NombreEstadio { get; set; }
        public string Direccion { get; set; }
        public Municipio Municipio { get; set; }  
    }
}