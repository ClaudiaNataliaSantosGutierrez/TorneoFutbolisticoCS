using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
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
            var jugador = _appContext.Jugadores
                      .Where(p => p.id==idJugador)
                      .Include(p => p.Equipo)
                      .FirstOrDefault();
            return jugador;
            //return _appContext.Jugadores.Find(idJugador);
        }

        public Jugador UpdateJugador(Jugador jugador)
        {
            var jugadorEncontrado = _appContext.Jugadores.Find(jugador.id);    //jugador.id
            if (jugadorEncontrado != null)
            {
                jugadorEncontrado.Nombre = jugador.Nombre;
                jugadorEncontrado.Apellidos = jugador.Apellidos;
                jugadorEncontrado.Documento = jugador.Documento;
                jugadorEncontrado.NumeroTelefono = jugador.NumeroTelefono;
                jugadorEncontrado.Id_P = jugador.Id_P;
                jugadorEncontrado.Numero = jugador.Numero;

                jugadorEncontrado.Posicion = jugador.Posicion;
                jugadorEncontrado.N_equipo = jugador.N_equipo;
                //jugadorEncontrado.Equipo = jugador.Equipo;
                _appContext.SaveChanges();
            }
            return jugadorEncontrado;
        }

        Equipo IRepositorioJugador.AsignarEquipo(int idJugador, int idEquipo)
        {
            var jugadorEncontrado = _appContext.Jugadores.FirstOrDefault(m => m.id == idJugador);
            if (jugadorEncontrado != null)
            {
                var equipoEncontrado = _appContext.Equipos.FirstOrDefault(p => p.Id == idEquipo);   //FirstOrDefault(m => m.Id == idEquipo);Find(idEquipo);
                if (equipoEncontrado != null)
                {
                    jugadorEncontrado.Equipo = equipoEncontrado;
                    _appContext.SaveChanges();
                }
                return equipoEncontrado;
            }
            return null;
        }

        IEnumerable<Jugador> IRepositorioJugador.SearchJugadores(string nombre)
        {
            return _appContext.Jugadores
                        .Where(p => p.Nombre.Contains(nombre));
        }
    }
}