//using System;
//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
/////using System;
/////using System.Collections.Generic;

namespace TorneoFutbolistico.App.Dominio
{   
    public class DirectorTecnico : Persona
    {
        [Required(ErrorMessage = "El codigo identificador de DirectorTecnico es obligatorio")]
        public int Id_DS { get; set; }
        public Equipo Equipo { get; set; }
    }
}