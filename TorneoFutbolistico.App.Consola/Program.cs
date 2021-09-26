using System;
using TorneoFutbolistico.App.Dominio;
using TorneoFutbolistico.App.Persistencia;

namespace TorneoFutbolistico.App.Consola
{
    class Program
    {
        ///private static IRepositorioJugador _repoJugador = new RepositorioJugador(new Persistencia.AppContext());
        //private static IRepositorioArbitro _repoArbitro = new RepositorioArbitro();
        //private static IRepositorioDesempeño _repoDesempeño = new RepositorioDesempeño();
        //private static IRepositorioNovedadPartido _repoNovedadPartido = new RepositorioNovedadPartido();
        private static IRepositorioPartido _repoPartido = new RepositorioPartido();
        //private static IRepositorioJugador _repoJugador = new RepositorioJugador();

       static void Main(string[] args)
       {
            Console.WriteLine("Hello World Entity Framework!");
            ///AddJugador();
            //BuscarPaciente(3);
            ////MostrarJugadores();
            //AddArbitro();
            //BuscarArbitro(3);
            //MostrarArbitros();
            //AddDesempeño();
            //BuscarDesempeño(3);
            //MostrarDesempeño();
            //AddNovedadPartido();
            //BuscarNovedadPartido(3);
            //MostrarNovedadPartido();
            AddPartido();
            //BuscarPartido(3);
            //MostrarPartido();
        }

        //private static void AddJugador()
        //private static void AddArbitro()
        //private static void AddDesempeño()
        //private static void AddNovedadPartido()
        private static void AddPartido()
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

            /*var arbitro = new Arbitro
            {
                Nombre = "Armando",
                Apellidos = "Juarez",
                //Documento = 3001647521,
                NumeroTelefono = "1241555",
                
                Id_A = 1242,
                Colegio = "Futbol Soccer College"
            };
            _repoArbitro.AddArbitro(arbitro);*/

            /*var desempeño = new Desempeño
            {
                //Id = 4521,
                PartidosJugados = 2,
                PartidosGanados = 2,
                PartidosEmpatados = 1,
                PartidosPerdidos = 3,
                GolesFavor = 6,
                GolesContra = 2,
                Puntos = 40
            };
            _repoDesempeño.AddDesempeño(desempeño);*/

            /*var novedadPartido = new NovedadPartido
            {
                Novedad = "Golpe a otro jugador",
                JugadorInvolucrado = "Pepe Perez",
                TarjetasAmarillas = 2,
                TarjetasRojas = 1,
                Goles = 3,
                Minuto = 20
            };
            _repoNovedadPartido.AddNovedadPartido(novedadPartido);*/

            var partido = new Partido
            {
                //Id = 4521,
                FechaHora = "Septiembre 15 de 2021",
                EquipoLocal = "Millonarios",
                MarcadorLocal = 2,
                EquipoVisitante = "Quindio",
                MarcadorVisitante  = 1
                
            };
            _repoPartido.AddPartido(partido);
        }

        //private static void BuscarJugador(int idJugador)
        //private static void BuscarArbitro(int idArbitro)
        //private static void BuscarDesempeño(int idDesempeño)
        //private static void BuscarNovedadPartido(int idNovedadPartido)
        private static void BuscarPartido(int idPartido)
        //private static void MostrarJugadores()
        {
            //var paciente = _repoPaciente.GetPaciente(idPaciente);
            ///var jugador = _repoJugador.GetJugador(idJugador);
            ///Console.WriteLine(jugador.Nombre+" "+jugador.Apellidos);
        }


        //private static void MostrarJugadores()
        //private static void MostrarArbitros()
        //private static void MostrarDesempeños()
        //private static void MostrarNovedadPartidos()
        private static void MostrarPartidos()
        {
            /*var Jugadores = _repoJugador.GetAllJugadores();
            foreach (var jugador in Jugadores)
            {
                Console.WriteLine(jugador.Nombre+" "+jugador.Apellidos);
            }*/

            /*var Arbitros = _repoArbitro.GetAllArbitros();
            foreach (var arbitro in Arbitros)
            {
                Console.WriteLine(arbitro.Nombre+" "+arbitro.Apellidos);
            }*/

            /*var Desempeños = _repoDesempeño.GetAllDesempeños();
            foreach (var desempeño in Desempeños)
            {
                Console.WriteLine(desempeño.PartidosGanados +" "+desempeño.Puntos);
            }*/

            /*var NovedadPartidos = _repoNovedadPartido.GetAllNovedadPartidos();
            foreach (var novedadPartido in NovedadPartidos)
            {
                Console.WriteLine(novedadPartido.Novedad +" "+novedadPartido.JugadorInvolucrado);
            }*/

            var Partidos = _repoPartido.GetAllPartidos();
            foreach (var partido in Partidos)
            {
                Console.WriteLine(partido.EquipoLocal +" "+partido.EquipoVisitante);
            }
        }
    }
}





