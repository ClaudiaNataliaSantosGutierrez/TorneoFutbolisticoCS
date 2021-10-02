using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Frontend.Pages.Arbitros
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioArbitro _repoArbitro;
        public Arbitro Arbitro {get; set;}
        public EditModel(IRepositorioArbitro repoArbitro)
        {
            _repoArbitro = repoArbitro;
        }
        public IActionResult OnGet(int Id_A)
        {
            Arbitro = _repoArbitro.GetArbitro(Id_A);
            if(Arbitro == null)
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
