//using System;
//using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TorneoFutbolistico.App.Dominio
{
      
    public class Desempeño
    {
        public int Id { get; set; } 
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Display(Name = "No Partidos Jugados")]
        public int PartidosJugados { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Display(Name = "No Partidos Ganados")]
        public int PartidosGanados { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Display(Name = "No Partidos Empatados")]
        public int PartidosEmpatados { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Display(Name = "No Partidos Perdidos")]
        public int PartidosPerdidos { get; set; } 
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Display(Name = "No Goles a Favor")]                                           
        public int GolesFavor { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Display(Name = "No Goles en Contra")]  
        public int GolesContra { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Display(Name = "No Puntos")]  
        public int Puntos { get; set; }
        //public Equipo Equipo { get; set; }
    }
}