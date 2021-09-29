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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        public DirectorTecnico directorTecnico {get; set;}
        public DetailsModel(IRepositorioDirectorTecnico repoDirectorTecnico)
        {
            _repoDirectorTecnico = repoDirectorTecnico;
        }
        public IActionResult OnGet(int id)
        {
            directorTecnico = _repoDirectorTecnico.GetDirectorTecnico(id);   //idJugador
            if(directorTecnico == null)
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
