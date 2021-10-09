using System.ComponentModel.DataAnnotations;

namespace TorneoFutbolistico.App.Dominio
{   
    public class Arbitro : Persona
    { 
        public int Id_A { get; set; }
        [Required(ErrorMessage = "El nombre del Colegio es obligatorio")]
        public string Colegio { get; set; }
        //public Partido Partido { get; set; }
    }
}