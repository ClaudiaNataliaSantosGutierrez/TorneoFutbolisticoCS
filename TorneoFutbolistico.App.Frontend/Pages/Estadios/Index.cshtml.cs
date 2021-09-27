using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Frontend.Pages.Estadios
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEstadio _repoEstadio;
        public IEnumerable<Estadio> Estadios {get; set;}
        public IndexModel(IRepositorioEstadio repoEstadio)
        {
            _repoEstadio= repoEstadio;
        }
        public void OnGet()
        {
            Estadios = _repoEstadio.GetAllEstadios();
        }
    }
}
