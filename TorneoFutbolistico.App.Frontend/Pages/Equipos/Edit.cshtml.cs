using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;
using Microsoft.AspNetCore.Authorization;

namespace TorneoFutbolistico.App.Frontend.Pages.Equipos
{
    [Authorize]
    public class EditModel : PageModel
   {
        private readonly IRepositorioEquipo _repoEquipo;
        public Equipo equipo {get; set;}
        public EditModel(IRepositorioEquipo repoEquipo)
        {
            _repoEquipo = repoEquipo;
        }
        public IActionResult OnGet(int Id)
        {
            equipo = _repoEquipo.GetEquipo(Id);   //idEquipo
            if(equipo == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Equipo equipo)
        {
            _repoEquipo.UpdateEquipo(equipo);   
            return RedirectToPage("Index");
           
            
        }
    }
}
