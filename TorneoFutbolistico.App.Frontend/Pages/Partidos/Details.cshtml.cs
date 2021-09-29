using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Frontend.Pages.Partidos
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        public Partido partido {get; set;}
        public DetailsModel(IRepositorioPartido repoPartido)
        {
            _repoPartido = repoPartido;
        }
        public IActionResult OnGet(int Id)
        {
            partido = _repoPartido.GetPartido(Id);   //idJugador
            if(partido == null)
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
