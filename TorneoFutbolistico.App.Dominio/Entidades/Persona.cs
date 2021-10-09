//using system;
using System.ComponentModel.DataAnnotations;
namespace TorneoFutbolistico.App.Dominio
{ 
    
    public class Persona
    {
        public int id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "El documento es obligatorio")]
        public int Documento { get; set; }
        [Required(ErrorMessage = "El NumeroTelefono es obligatorio")]
        public string NumeroTelefono { get; set; }

    }
}