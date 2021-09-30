//using System;
//using System.Collections.Generic;
using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;

namespace TorneoFutbolistico.App.Dominio
{
      
    public class Desempeño
    {
        public int Id { get; set; } 
        public int PartidosJugados { get; set; }
        public int PartidosGanados { get; set; }
        public int PartidosEmpatados { get; set; }
        public int PartidosPerdidos { get; set; }
        public int GolesFavor { get; set; }
        public int GolesContra { get; set; }
        public int Puntos { get; set; }
        //public Equipo Equipo { get; set; }
    }
}