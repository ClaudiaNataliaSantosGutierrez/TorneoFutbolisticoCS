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
    public class AddEquipoModel : PageModel
    {
        private readonly IRepositorioMunicipio _repoMunicipio;
        private readonly IRepositorioEquipo _repoEquipo;
        public Municipio municipio {get;set;}
        public IEnumerable<Equipo> equipos {get;set;}
        public AddEquipoModel(IRepositorioMunicipio repoMunicipio, IRepositorioEquipo repoEquipo)
        {
            _repoMunicipio = repoMunicipio;
            _repoEquipo = repoEquipo;
        }

        public void OnGet(int id)
        {
            municipio = _repoMunicipio.GetMunicipio(id);
            equipos = _repoEquipo.GetAllEquipos();
        }

        public IActionResult OnPost(int idMunicipio, int idEquipo)
        {
            _repoMunicipio.AsignarEquipo(idMunicipio, idEquipo);
            return RedirectToPage("Index");
        }
    }
}
