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
    public class AddEquipoModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        private readonly IRepositorioEquipo _repoEquipo;
        public DirectorTecnico directorTecnico {get;set;}
        public IEnumerable<Equipo> equipos {get;set;}
        public AddEquipoModel(IRepositorioDirectorTecnico repoDirectorTecnico, IRepositorioEquipo repoEquipo)
        {
            _repoDirectorTecnico = repoDirectorTecnico;
            _repoEquipo = repoEquipo;
        }

        public void OnGet(int id)
        {
            directorTecnico = _repoDirectorTecnico.GetDirectorTecnico(id);
            equipos = _repoEquipo.GetAllEquipos();
        }

        public IActionResult OnPost(int idDirectorTecnico, int idEquipo)
        {
            _repoDirectorTecnico.AsignarEquipo(idDirectorTecnico, idEquipo);
            return RedirectToPage("Index");
        }
    }
}
