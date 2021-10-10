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
    public class AddArbitroModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        private readonly IRepositorioArbitro _repoArbitro;
        public Partido partido {get;set;}
        public IEnumerable<Arbitro> arbitros {get;set;}
        public AddArbitroModel(IRepositorioPartido repoPartido, IRepositorioArbitro repoArbitro)
        {
            _repoPartido = repoPartido;
            _repoArbitro = repoArbitro;
        }

        public void OnGet(int Id)
        {
            partido = _repoPartido.GetPartido(Id);
            arbitros = _repoArbitro.GetAllArbitros();
        }

        public IActionResult OnPost(int idPartido, int idArbitro)
        {
            _repoPartido.AsignarArbitro(idPartido, idArbitro);
            return RedirectToPage("Index");
        }
    }
}
