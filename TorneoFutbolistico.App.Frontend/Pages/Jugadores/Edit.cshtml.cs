using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Frontend.Pages.Jugadores
{
    public class EditModel : PageModel
     {
        private readonly IRepositorioJugador _repoJugador;
        public Jugador Jugador {get; set;}
        public EditModel(IRepositorioJugador repoJugador)
        {
            _repoJugador = repoJugador;
        }
        public IActionResult OnGet(int idJugador)
        {
            Jugador = _repoJugador.GetJugador(idJugador);
            if(Jugador == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
          public IActionResult OnPost(Jugador jugador)
        {
            _repoJugador.UpdateJugador(jugador);   
            return RedirectToPage("Index");
           
            
        }

    }
}
