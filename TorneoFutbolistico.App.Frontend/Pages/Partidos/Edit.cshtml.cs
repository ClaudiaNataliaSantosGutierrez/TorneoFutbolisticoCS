using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;
using Microsoft.AspNetCore.Authorization;

namespace TorneoFutbolistico.App.Frontend.Pages.Partidos
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        public Partido partido {get; set;}
        public EditModel(IRepositorioPartido repoPartido)
        {
            _repoPartido = repoPartido;
        }
        public IActionResult OnGet(int Id)
        {
            partido = _repoPartido.GetPartido(Id);   //idPartido
            if(partido == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
          public IActionResult OnPost(Partido partido)
        {
            _repoPartido.UpdatePartido(partido);
            return RedirectToPage("Index");
           
        }
    }
}
