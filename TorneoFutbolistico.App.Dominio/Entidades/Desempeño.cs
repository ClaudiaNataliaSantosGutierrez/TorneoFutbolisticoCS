//using System;
//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
/////using System;
/////using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;

namespace TorneoFutbolistico.App.Dominio
{
      
    public class Desempeño
    {
        public int Id { get; set; } 
        [Required(ErrorMessage = "Digitar los PartidosJugados es obligatorio")]
        public int PartidosJugados { get; set; }
        [Required(ErrorMessage = "Digitar los PartidosGanados es obligatorio")]
        public int PartidosGanados { get; set; }
        [Required(ErrorMessage = "Digitar los PartidosEmpatados es obligatorio")]
        public int PartidosEmpatados { get; set; }
        [Required(ErrorMessage = "Digitar los PartidosPerdidos es obligatorio")]
        public int PartidosPerdidos { get; set; }   
        [Required(ErrorMessage = "Digitar los GolesFavor es obligatorio")]                                         
        public int GolesFavor { get; set; }
        [Required(ErrorMessage = "Digitar los olesContra es obligatorio")]
        public int GolesContra { get; set; }
        [Required(ErrorMessage = "Digitar los Puntos es obligatorio")]
        public int Puntos { get; set; }
        //public Equipo Equipo { get; set; }
    }
}