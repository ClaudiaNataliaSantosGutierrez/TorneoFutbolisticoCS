using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Frontend.Pages.Partidos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        public IEnumerable<Partido> Partidos {get; set;}
        public string bActual {get; set;}
        public IndexModel(IRepositorioPartido repoPartido)
        {
            _repoPartido = repoPartido;
        }
        public void OnGet(string b)
        {
            if(string.IsNullOrEmpty(b))
            {
                bActual = "";
                Partidos = _repoPartido.GetAllPartidos();
            }
            else
            {
                bActual = b;
                Partidos = _repoPartido.SearchPartidos(b);
            }
            //Partidos = _repoPartido.GetAllPartidos();
        }
    }
}
