using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;
using Microsoft.AspNetCore.Authorization;

namespace TorneoFutbolistico.App.Frontend.Pages.Desempeños
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly IRepositorioDesempeño _repoDesempeño;
        public Desempeño desempeño {get; set;}
        public CreateModel(IRepositorioDesempeño repoDesempeño)
        {
            _repoDesempeño = repoDesempeño;
        }
        public void OnGet()
        {
            desempeño = new Desempeño();
        }
        public IActionResult OnPost(Desempeño desempeño)
        {
            if(ModelState.IsValid)
            {
               _repoDesempeño.AddDesempeño(desempeño);   
               return RedirectToPage("Index"); 
            }
            else
            {
                return Page();
            }
        }
    }
}
