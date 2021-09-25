using System;
using TorneoFutbolistico.App.Dominio;
using TorneoFutbolistico.App.Persistencia;

namespace TorneoFutbolistico.App.Consola
{
    class Program
    {
        ///private static IRepositorioJugador _repoJugador = new RepositorioJugador(new Persistencia.AppContext());
        private static IRepositorioArbitro _repoArbitro = new RepositorioArbitro();
        //private static IRepositorioJugador _repoJugador = new RepositorioJugador();

       static void Main(string[] args)
       {
            Console.WriteLine("Hello World Entity Framework!");
            ///AddJugador();
            //BuscarPaciente(3);
            ////MostrarJugadores();
            //AddArbitro();
            //BuscarArbitro(3);
            MostrarArbitros();
        }

        //private static void AddJugador()
        private static void AddArbitro()
        {
            /*var jugador = new Jugador
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
            _repoJugador.AddJugador(jugador);*/

            var arbitro = new Arbitro
            {
                Nombre = "Armando",
                Apellidos = "Juarez",
                //Documento = 3001647521,
                NumeroTelefono = "1241555",
                
                Id_A = 1242,
                Colegio = "Futbol Soccer College"
            };
            _repoArbitro.AddArbitro(arbitro);
        }

        //private static void BuscarJugador(int idJugador)
        private static void BuscarArbitro(int idArbitro)
        //private static void MostrarJugadores()
        {
            //var paciente = _repoPaciente.GetPaciente(idPaciente);
            ///var jugador = _repoJugador.GetJugador(idJugador);
            ///Console.WriteLine(jugador.Nombre+" "+jugador.Apellidos);
        }


        //private static void MostrarJugadores()
        private static void MostrarArbitros()
        {
            /*var Jugadores = _repoJugador.GetAllJugadores();
            foreach (var jugador in Jugadores)
            {
                Console.WriteLine(jugador.Nombre+" "+jugador.Apellidos);
            }*/

            var Arbitros = _repoArbitro.GetAllArbitros();
            foreach (var arbitro in Arbitros)
            {
                Console.WriteLine(arbitro.Nombre+" "+arbitro.Apellidos);
            }
        }



/*       {
            Console.WriteLine("Hello World Entity Framework!");
            AddArbitro();
            //BuscarArbitro(3);
            //MostrarArbitros();
        }

        private static void AddArbitro()
       {
            var arbitro = new Arbitro
            {
                Nombre = "Denis",
                Apellidos = "Guzman",
                Documento = 3001647521,
                NumeroTelefono = "1241555",
                
                Id_A = 1242,
                Colegio = "Futbol Soccer College"
            };
            _repoArbitro.AddArbitro(arbitro);
        }

/*        private static void MostrarArbitros()
        {
            var Arbitros = _repoArbitro.GetAllArbitros();
            foreach (var arbitro in Arbitros)
            {
                Console.WriteLine(arbitro.Nombre+" "+arbitro.Apellidos);
            }
        }*/
    }
}





