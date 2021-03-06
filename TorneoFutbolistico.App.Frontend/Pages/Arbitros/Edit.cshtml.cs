using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;
using Microsoft.AspNetCore.Authorization;

namespace TorneoFutbolistico.App.Frontend.Pages.Arbitros
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly IRepositorioArbitro _repoArbitro;
        public Arbitro arbitro {get; set;}
        public EditModel(IRepositorioArbitro repoArbitro)
        {
            _repoArbitro = repoArbitro;
        }
        public IActionResult OnGet(int id)
        {
            arbitro = _repoArbitro.GetArbitro(id);
            if(arbitro == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            } 
            
        }
        public IActionResult OnPost(Arbitro arbitro)
        {
            _repoArbitro.UpdateArbitro(arbitro);
            return RedirectToPage("Index");
            
        }
    }
}
