using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Frontend.Pages.Desempeños
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioDesempeño _repoDesempeño;
        public IEnumerable<Desempeño> Desempeños {get; set;}
        //public string bActual {get; set;}
        public IndexModel(IRepositorioDesempeño repoDesempeño)
        {
            _repoDesempeño = repoDesempeño;
        }
        public void OnGet()
        {
            Desempeños = _repoDesempeño.GetAllDesempeños();
        }
    }
}
