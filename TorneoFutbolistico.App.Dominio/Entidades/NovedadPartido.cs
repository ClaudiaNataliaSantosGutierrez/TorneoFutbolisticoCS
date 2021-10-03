using System.ComponentModel.DataAnnotations;
namespace TorneoFutbolistico.App.Dominio
{
      
    public class NovedadPartido
    {
        public int Id { get; set; } 
        [Required(ErrorMessage = "La Novedad es obligatoria")]
        public string Novedad { get; set; } 
        [Required(ErrorMessage = "El JugadorInvolucrado es obligatorio")]
        public string JugadorInvolucrado { get; set; }
        public int TarjetasAmarillas { get; set; }
        public int TarjetasRojas { get; set; }
        public int Goles { get; set; }
        [Required(ErrorMessage = "El Minuto es obligatorio")]
        public int Minuto { get; set; }
    }
}