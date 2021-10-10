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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        public IEnumerable<DirectorTecnico> DirectoresTecnicos {get; set;}
        public string bActual {get; set;}
        public IndexModel(IRepositorioDirectorTecnico repoDirectorTecnico)
        {
            _repoDirectorTecnico = repoDirectorTecnico;
        }
        public void OnGet(string b)
        {
            if(string.IsNullOrEmpty(b))
            {
                bActual = "";
                DirectoresTecnicos = _repoDirectorTecnico.GetAllDirectoresTecnicos();
            }
            else
            {
                bActual = b;
                DirectoresTecnicos = _repoDirectorTecnico.SearchDirectoresTecnicos(b);
            }
            //DirectoresTecnicos = _repoDirectorTecnico.GetAllDirectoresTecnicos();
        }
    }
}

