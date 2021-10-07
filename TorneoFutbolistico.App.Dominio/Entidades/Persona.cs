//using system;
using System.ComponentModel.DataAnnotations;

namespace TorneoFutbolistico.App.Dominio
{ 
    
    public class Persona
    {
        public int id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        [Display(Name = "Documento de Identidad de Persona")]
        public int Documento { get; set; }
        [Phone(ErrorMessage = "Debe Ingresar un numero telefonico")]
        [Display(Name = "Numero telefonico")]
        public string NumeroTelefono { get; set; }

    }
}