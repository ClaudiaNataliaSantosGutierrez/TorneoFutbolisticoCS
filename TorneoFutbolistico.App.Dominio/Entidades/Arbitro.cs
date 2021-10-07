using System.ComponentModel.DataAnnotations;
namespace TorneoFutbolistico.App.Dominio
{   
    public class Arbitro : Persona
    { 
        public int Id_A { get; set; }
        [Required(ErrorMessage = "El Colegio es obligatorio")]
        [Display(Name = "Colegio de Arbitros Al que pertenece")]
        public string Colegio { get; set; }
        //public Partido Partido { get; set; }
    }
}