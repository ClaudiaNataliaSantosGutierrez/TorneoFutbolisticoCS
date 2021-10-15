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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioArbitro _repoArbitro;
        public Arbitro Arbitro {get; set;}
        public CreateModel(IRepositorioArbitro repoArbitro)
        {
            _repoArbitro = repoArbitro;
        }
        public void OnGet()
        {
            Arbitro = new Arbitro();   
            
        }
        public IActionResult OnPost(Arbitro arbitro)
        {
            if(ModelState.IsValid)
            {
                _repoArbitro.AddArbitro(arbitro);   
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }  
        }
        
    }
}
