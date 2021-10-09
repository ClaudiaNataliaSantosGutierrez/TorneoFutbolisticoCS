using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Frontend.Pages.NovedadesPartidos
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioNovedadPartido _repoNovedadPartido;
        public NovedadPartido novedadPartido {get; set;}
        public CreateModel(IRepositorioNovedadPartido repoNovedadPartido)
        {
            _repoNovedadPartido = repoNovedadPartido;
        }
        public void OnGet()
        {
            novedadPartido = new NovedadPartido();
        }
        public IActionResult OnPost(NovedadPartido novedadPartido)
        {
            if(ModelState.IsValid)
            {
                _repoNovedadPartido.AddNovedadPartido(novedadPartido);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();//
            }
        }
    }
}
