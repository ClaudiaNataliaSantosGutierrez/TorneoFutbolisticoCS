using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Frontend.Pages.NovedadPartido
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioNovedadPartido _repoNovedadPartido;
        public IEnumerable<NovedadPartido> NovedadPartidos {get; set;}
        public IndexModel(IRepositorioNovedadPartido repoNovedadPartido)
        {
            _repoNovedadPartido = repoNovedadPartido;
        }
        public void OnGet()
        {
            NovedadPartidos = _repoNovedadPartido.GetAllNovedadPartidos();
        }
    }
}
