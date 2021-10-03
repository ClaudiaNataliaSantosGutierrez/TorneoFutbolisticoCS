using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Frontend.Pages.Municipios
{
    public class EditModel : PageModel
    {
      private readonly IRepositorioMunicipio _repoMunicipio;
        public Municipio municipio {get; set;}
        public EditModel(IRepositorioMunicipio repoMunicipio)
        {
            _repoMunicipio = repoMunicipio;
        }
        public IActionResult OnGet(int Id)
        {
            municipio = _repoMunicipio.GetMunicipio(Id);   //idMunicipio
            if(municipio == null)
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
