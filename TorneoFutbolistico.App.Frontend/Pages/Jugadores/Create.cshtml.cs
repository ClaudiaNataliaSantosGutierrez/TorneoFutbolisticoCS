using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;
using Microsoft.AspNetCore.Authorization;

namespace TorneoFutbolistico.App.Frontend.Pages.Jugadores
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly IRepositorioJugador _repoJugador;
        public Jugador Jugador {get; set;}
        public CreateModel(IRepositorioJugador repoJugador)
        {
            _repoJugador = repoJugador;
        }
        public void OnGet()
        {
            Jugador = new Jugador();
        }
          public IActionResult OnPost(Jugador jugador)
        {
            if(ModelState.IsValid)
            {
                _repoJugador.AddJugador(jugador);   
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }

    }
}
