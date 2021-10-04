//using System;
//using System.Collections.Generic;
using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
namespace TorneoFutbolistico.App.Dominio
{   
    public class DirectorTecnico : Persona
    {
        public int Id_DS { get; set; }
        public Equipo Equipo { get; set; }
    }
}