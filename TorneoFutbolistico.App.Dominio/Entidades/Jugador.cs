//using System;
//using System.Collections.Generic;
namespace TorneoFutbolistico.App.Dominio
{  
    
    public class Jugador : Persona
    {
        public int Id_P { get; set; }
        public int Numero { get; set; }
        public string Posicion { get; set; }
        public int N_equipo { get; set; }
        public Equipo Equipo { get; set; }
        
    }
}