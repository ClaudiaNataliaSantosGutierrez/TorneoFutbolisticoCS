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
        public IndexModel(IRepositorioEquipo repoEquipo)
        {
            _repoEquipo= repoEquipo;
        }
        public void OnGet()
        {
            Equipos = _repoEquipo.GetAllEquipos();
        }
    }
}
