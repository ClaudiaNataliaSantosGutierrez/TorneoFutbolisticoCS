using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Frontend.Pages.DirectoresTecnicos
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        public DirectorTecnico directorTecnico {get; set;}
        public EditModel(IRepositorioDirectorTecnico repoDirectorTecnico)
        {
            _repoDirectorTecnico = repoDirectorTecnico;
        }
        public IActionResult OnGet(int id)
        {
            DirectorTecnico = _repoDirectorTecnico.GetDirectorTecnico(id);
            if(DirectorTecnico == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            } 
            
        }
        public IActionResult OnPost(DirectorTecnico directorTecnico)
        {
            _repoDirectorTecnico.UpdateDirectorTecnico(directorTecnico);
            return RedirectToPage("Index");
            
        }
    }
}
