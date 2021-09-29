using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Frontend.Pages.Desempeños
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioDesempeño _repoDesempeño;
        public Desempeño desempeño {get; set;}
        public DetailsModel(IRepositorioDesempeño repoDesempeño)
        {
            _repoDesempeño = repoDesempeño;
        }
        public IActionResult OnGet(int Id)
        {
            desempeño = _repoDesempeño.GetDesempeño(Id);   //idJugador
            if(desempeño == null)
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
