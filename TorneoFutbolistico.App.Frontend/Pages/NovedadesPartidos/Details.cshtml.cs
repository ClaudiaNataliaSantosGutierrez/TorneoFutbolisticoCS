using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Frontend.Pages.NovedadesPartidos
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioNovedadPartido _repoNovedadPartido;
        public NovedadPartido novedadPartido {get; set;}
        public DetailsModel(IRepositorioNovedadPartido repoNovedadPartido)
        {
            _repoNovedadPartido = repoNovedadPartido;
        }
        public IActionResult OnGet(int Id)
        {
            novedadPartido = _repoNovedadPartido.GetNovedadPartido(Id);   ///idJugador
            if(novedadPartido == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}
