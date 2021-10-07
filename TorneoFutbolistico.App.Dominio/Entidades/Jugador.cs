//using System;
//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace TorneoFutbolistico.App.Dominio
{  
    
    public class Jugador : Persona
    {
        public int Id_P { get; set; }
        [Required(ErrorMessage = "El numero es Obligatorio")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "La posición es obligatoria")]
        public string Posicion { get; set; }
        public int N_equipo { get; set; }
        public Equipo Equipo { get; set; }
        
    }
}