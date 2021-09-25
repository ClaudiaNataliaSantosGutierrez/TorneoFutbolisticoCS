using System.Collections.Generic;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Persistencia
{
    public class RepositorioJugador : IRepositorioJugador
    {
        //private readonly AppContext _appContext;
        private readonly AppContext _appContext = new AppContext();

        //public RepositorioJugador(AppContext appContext)
        //{
        //    _appContext = appContext;
        //}

        public Jugador AddJugador(Jugador jugador)      
        {
            var jugadorAdicionado = _appContext.Jugadores.Add(jugador);
            _appContext.SaveChanges();
            return jugadorAdicionado.Entity;
        }

        public void DeleteJugador(int idJugador)
        {
            var jugadorEncontrado = _appContext.Jugadores.Find(idJugador);
            if (jugadorEncontrado == null)
                return;
            _appContext.Jugadores.Remove(jugadorEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Jugador> GetAllJugadores()
        {
            return _appContext.Jugadores;
        }

        public Jugador GetJugador(int idJugador)
        {
            return _appContext.Jugadores.Find(idJugador);
        }

        public Jugador UpdateJugador(Jugador jugador)
        {
            var jugadorEncontrado = _appContext.Jugadores.Find(jugador.id);    //jugador.Id
            if (jugadorEncontrado != null)
            {
                jugadorEncontrado.Nombre = jugador.Nombre;
                jugadorEncontrado.Apellidos = jugador.Apellidos;
                jugadorEncontrado.Documento = jugador.Documento;
                jugadorEncontrado.NumeroTelefono = jugador.NumeroTelefono;
                jugadorEncontrado.Id_P = jugador.Id_P;
                jugadorEncontrado.Numero = jugador.Numero;
                jugadorEncontrado.N_equipo = jugador.N_equipo;
                //jugadorEncontrado.Equipo = jugador.Equipo;
                _appContext.SaveChanges();
            }
            return jugadorEncontrado;
        }
    }
}