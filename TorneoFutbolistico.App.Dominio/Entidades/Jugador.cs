//using System;
//using System.Collections.Generic;//
using System.ComponentModel.DataAnnotations;

namespace TorneoFutbolistico.App.Dominio
{  
    
    public class Jugador : Persona
    {
        public int Id_P { get; set; }
        [Required(ErrorMessage = "El Numero es obligatorio")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "La Posicion es obligatoria")]
        public string Posicion { get; set; }
        [Required(ErrorMessage = "El N_equipo es obligatorio")]
        public int N_equipo { get; set; }
        public Equipo Equipo { get; set; }
        
    }
}