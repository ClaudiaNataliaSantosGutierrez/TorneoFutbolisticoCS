using System;
using TorneoFutbolistico.App.Dominio;
using TorneoFutbolistico.App.Persistencia;

namespace TorneoFutbolistico.App.Consola
{
    class Program
    {
        private static IRepositorioJugador _repoJugador = new RepositorioJugador(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity Framework!");
            AddJugador();
            //BuscarPaciente(3);
            //MostrarPacientes();
        }

        private static void AddJugador()
        {
            var jugador = new Jugador
            {
                Nombre = "Pepito",
                Apellidos = "Perez",
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
            var jugador = _repoJugador.GetJugador(idJugador);
            Console.WriteLine(jugador.Nombre+" "+jugador.Apellidos);
        }
    }
}





