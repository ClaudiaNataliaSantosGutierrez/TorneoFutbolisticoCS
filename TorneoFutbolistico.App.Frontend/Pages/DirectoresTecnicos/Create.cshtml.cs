using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;
using Microsoft.AspNetCore.Authorization;

namespace TorneoFutbolistico.App.Frontend.Pages.DirectoresTecnicos
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        public DirectorTecnico directorTecnico {get; set;}
        public CreateModel(IRepositorioDirectorTecnico repoDirectorTecnico)
        {
            _repoDirectorTecnico = repoDirectorTecnico;
        }
        public void OnGet()
        {
            directorTecnico = new DirectorTecnico();
        }
        public IActionResult OnPost(DirectorTecnico directorTecnico)
        {
            if(ModelState.IsValid)
            {
                _repoDirectorTecnico.AddDirectorTecnico(directorTecnico);   
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            } 
        }
    }
}
