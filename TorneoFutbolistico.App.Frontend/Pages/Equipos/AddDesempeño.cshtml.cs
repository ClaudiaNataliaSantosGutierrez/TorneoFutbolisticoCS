using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Frontend.Pages.Equipos
{
    public class AddDesempeñoModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioDesempeño _repoDesempeño;
        public Equipo equipo {get;set;}
        public IEnumerable<Desempeño> desempeños {get;set;}
        public AddDesempeñoModel(IRepositorioEquipo repoEquipo, IRepositorioDesempeño repoDesempeño)
        {
            _repoEquipo= repoEquipo;
            _repoDesempeño = repoDesempeño;
        }

        public void OnGet(int id)
        {
            equipo = _repoEquipo.GetEquipo(id);
            desempeños = _repoDesempeño.GetAllDesempeños();
        }

        public IActionResult OnPost(int idEquipo, int idDesempeño)
        {
            _repoEquipo.AsignarDesempeño(idEquipo, idDesempeño);
            return RedirectToPage("Index");
        }
    }
}
