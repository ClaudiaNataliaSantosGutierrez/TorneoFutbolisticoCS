using System;
using TorneoFutbolistico.App.Dominio;
using TorneoFutbolistico.App.Persistencia;

namespace TorneoFutbolistico.App.Consola
{
    class Program
    {
        //private static IRepositorioJugador _repoJugador = new RepositorioJugador(new Persistencia.AppContext());
        private static IRepositorioJugador _repoJugador = new RepositorioJugador();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity Framework!");
            ///AddJugador();
            //BuscarPaciente(3);
            MostrarJugadores();
        }

        private static void AddJugador()
        {
            var jugador = new Jugador
            {
                Nombre = "Natalia",
                Apellidos = "Santos",
                Documento = 300164521,
                NumeroTelefono = "1247890",
                
                Id_P = 1202,
                Numero = 5,
                Posicion = "Delantero",
                N_equipo = 1
            };
            _repoJugador.AddJugador(jugador);
        }

        private static void BuscarJugador(int idJugador)
        //private static void MostrarJugadores()
        {
            //var paciente = _repoPaciente.GetPaciente(idPaciente);
            ///var jugador = _repoJugador.GetJugador(idJugador);
            ///Console.WriteLine(jugador.Nombre+" "+jugador.Apellidos);
        }


        private static void MostrarJugadores()
        {
            var Jugadores = _repoJugador.GetAllJugadores();
            foreach (var jugador in Jugadores)
            {
                Console.WriteLine(jugador.Nombre+" "+jugador.Apellidos);
            }
        }
    }
}





