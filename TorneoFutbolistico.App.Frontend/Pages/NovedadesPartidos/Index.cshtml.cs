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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioNovedadPartido _repoNovedadPartido;
        public IEnumerable<NovedadPartido> NovedadesPartido {get; set;}
        public string bActual {get; set;}
        public IndexModel(IRepositorioNovedadPartido repoNovedadPartido)
        {
            _repoNovedadPartido = repoNovedadPartido;
        }
        public void OnGet(string b)
        {
            if(string.IsNullOrEmpty(b))
            {
                bActual = "";
                NovedadesPartido = _repoNovedadPartido.GetAllNovedadesPartido();
            }
            else
            {
                bActual = b;
                NovedadesPartido = _repoNovedadPartido.SearchNovedadesPartido(b);
            }
            //NovedadesPartido = _repoNovedadPartido.GetAllNovedadesPartido();
        }
    }
}
