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
    public class EditModel : PageModel
    {
        private readonly IRepositorioDesempeño _repoDesempeño;
        public Desempeño desempeño {get; set;}
        public EditModel(IRepositorioDesempeño repoDesempeño)
        {
            _repoDesempeño = repoDesempeño;
        }
        public IActionResult OnGet(int Id)
        {
            desempeño = _repoDesempeño.GetDesempeño(Id);   //idDesempeño
            if(desempeño == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
          public IActionResult OnPost(Desempeño desempeño)
        {
            _repoDesempeño.UpdateDesempeño(desempeño);
            return RedirectToPage("Index");
           
        }
    }
}
