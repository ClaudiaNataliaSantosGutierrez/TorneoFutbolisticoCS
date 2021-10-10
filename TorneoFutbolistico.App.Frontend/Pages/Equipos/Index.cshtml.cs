using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Frontend.Pages.Equipos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        public IEnumerable<Equipo> Equipos {get; set;}
        public string bActual {get; set;}
        public IndexModel(IRepositorioEquipo repoEquipo)
        {
            _repoEquipo= repoEquipo;
        }
        public void OnGet(string b)
        {
            if(string.IsNullOrEmpty(b))
            {
                bActual = "";
                Equipos = _repoEquipo.GetAllEquipos();;
            }
            else
            {
                bActual = b;
                Equipos = _repoEquipo.SearchEquipos(b);
            }
            //Equipos = _repoEquipo.GetAllEquipos();
        }
    }
}
