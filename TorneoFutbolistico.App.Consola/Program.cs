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
        //private static IRepositorioPartido _repoPartido = new RepositorioPartido();
        //private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio();
        //private static IRepositorioEstadio _repoEstadio= new RepositorioEstadio();
        //private static IRepositorioEquipo _repoEquipo= new RepositorioEquipo();
        //private static IRepositorioDirectorTecnico _repoDirectorTecnico= new RepositorioDirectorTecnico();
        private static IRepositorioJugador _repoJugador = new RepositorioJugador();

       static void Main(string[] args)
       {
            Console.WriteLine("Hello World Entity Framework!");
            AddJugador();
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
            //AddPartido();
            //BuscarPartido(3);
            //MostrarPartido();
            //AddMunicipio();
            //BuscarMunicipio(3);
            //MostrarMunicipio();
            //AddEstadio();
            //BuscarEstadio(3);
            //MostrarEstadio();
            //AddEquipo();
            //BuscarEquipo(3);
            //MostrarEquipo();
            //AddDirectorTecnico();
            //BuscarDirectorTecnico(3);
            //MostrarDirectorTecnico();
        }

        private static void AddJugador()
        //private static void AddArbitro()
        //private static void AddDesempeño()
        //private static void AddNovedadPartido()
        //private static void AddPartido()
        //private static void AddMunicipio()
        //private static void AddEstadio()
        //private static void AddEquipo()
        //private static void AddDirectorTecnico()
        {
            var jugador = new Jugador
            {
                Nombre = "Daniel",
                Apellidos = "Aguirre",
                Documento = 3525521,
                NumeroTelefono = "1859690",
                Id_P = 2562,
                Numero = 3,
                Posicion = "Delantero",
                N_equipo = 3
            };
            _repoJugador.AddJugador(jugador);

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

            /*var partido = new Partido
            {
                //Id = 4521,
                FechaHora = "Septiembre 15 de 2021",
                EquipoLocal = "Millonarios",
                MarcadorLocal = 2,
                EquipoVisitante = "Quindio",
                MarcadorVisitante  = 1
                
            };
            _repoPartido.AddPartido(partido);*/

            /*var municipio = new Municipio
            {
                //Id = 1020,
                NombreMunicipio = "Bolivar",
            };
            _repoMunicipio.AddMunicipio(municipio);*/

            /*var estadio = new Estadio
            {
                //Id = 1099,
                NombreEstadio = "Coliseo Roma",
                Direccion = "calle 130",
            };
            _repoEstadio.AddEstadio(estadio);*/

            /*var equipo = new Equipo
            {
                //Id = 1099,
                NombreEquipo = "MVP",
            };
            _repoEquipo.AddEquipo(equipo);*/

            /*var directorTecnico = new DirectorTecnico
            {
                Nombre = "Luis",
                Apellidos = "Paez",
                Documento = 38404851,
                NumeroTelefono = "1212036",
                Id_DS = 9845,
            };
            _repoDirectorTecnico.AddDirectorTecnico(directorTecnico);*/
        }

        private static void BuscarJugador(int idJugador)
        //private static void BuscarArbitro(int idArbitro)
        //private static void BuscarDesempeño(int idDesempeño)
        //private static void BuscarNovedadPartido(int idNovedadPartido)
        //private static void BuscarPartido(int idPartido)
        //private static void BuscarMunicipio(int idMunicipio)
        //private static void BuscarEstadio(int idEstadio)
        //private static void BuscarEquipo(int idEquipo)
        //private static void BuscarDirectorTecnico(int idDirectorTecnico)
        //private static void MostrarJugadores()
        {
            //var paciente = _repoPaciente.GetPaciente(idPaciente);
            ///var jugador = _repoJugador.GetJugador(idJugador);
            ///Console.WriteLine(jugador.Nombre+" "+jugador.Apellidos);
        }


        private static void MostrarJugadores()
        //private static void MostrarArbitros()
        //private static void MostrarDesempeños()
        //private static void MostrarNovedadPartidos()
        //private static void MostrarPartidos()
        //private static void MostrarMunicipios()
        //private static void MostrarEstadios()
        //private static void MostrarEquipos()
        //private static void MostrarDirectoresTecnicos()
        {
            var Jugadores = _repoJugador.GetAllJugadores();
            foreach (var jugador in Jugadores)
            {
                Console.WriteLine(jugador.Nombre+" "+jugador.Apellidos);
            }

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

            /*var Partidos = _repoPartido.GetAllPartidos();
            foreach (var partido in Partidos)
            {
                Console.WriteLine(partido.EquipoLocal +" "+partido.EquipoVisitante);
            }*/

            /*var Municipios = _repoMunicipio.GetAllMunicipios();
            foreach (var municipio in Municipios)
            {
                Console.WriteLine(municipio.NombreMunicipio);
            }*/

            /*var Estadios = _repoEstadio.GetAllEstadios();
            foreach (var estadio in Estadios)
            {
                Console.WriteLine(estadio.NombreEstadio+" "+estadio.Direccion);
            }*/

            /*var Equipos = _repoEquipo.GetAllEquipos();
            foreach (var equipo in Equipos)
            {
                Console.WriteLine(equipo.NombreEquipo);
            }*/

            /*var DirectoresTecnicos = _repoDirectorTecnico.GetAllDirectoresTecnicos();
            foreach (var directorTecnico in DirectoresTecnicos)
            {
                Console.WriteLine(directorTecnico.Nombre+" "+directorTecnico.Apellidos);
            }*/
        }
    }
}





