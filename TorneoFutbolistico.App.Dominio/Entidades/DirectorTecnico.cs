namespace TorneoFutbolistico.App.Dominio
{   
    public class DirectorTecnico : Persona
    {
        public int Id_DS { get; set; }
        [Required(ErrorMessage = "El Equipo es obligatorio")]
        [Display(Name = "Equipo al que pertenece")]
        public Equipo Equipo { get; set; }
    }
}
