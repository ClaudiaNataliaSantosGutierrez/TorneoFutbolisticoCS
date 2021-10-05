using System;
using TorneoFutbolistico.App.Dominio;
using TorneoFutbolistico.App.Persistencia;

namespace TorneoFutbolistico.App.Consola
{
    class Program
    {
        ///////-- REPOSITORIOS DEL PROYECTO--\\\\\\

        //--private static IRepositorioJugador _repoJugador = new RepositorioJugador(new Persistencia.AppContext());--\\-REPOSITORIO INICIAL MUESTRA
        //private static IRepositorioArbitro _repoArbitro = new RepositorioArbitro();
        //private static IRepositorioDesempeño _repoDesempeño = new RepositorioDesempeño();
        private static IRepositorioNovedadPartido _repoNovedadPartido = new RepositorioNovedadPartido();
        //private static IRepositorioPartido _repoPartido = new RepositorioPartido();
        //private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio();
        //private static IRepositorioEstadio _repoEstadio= new RepositorioEstadio();
        //private static IRepositorioEquipo _repoEquipo= new RepositorioEquipo();
        //private static IRepositorioDirectorTecnico _repoDirectorTecnico= new RepositorioDirectorTecnico();
        //private static IRepositorioJugador _repoJugador = new RepositorioJugador();
        //private static IRepositorioJugador _repoJugador = new RepositorioJugador();

       static void Main(string[] args)
       {
            Console.WriteLine("Hello World Entity Framework!");

            ////--ACCIONES DE JUGADOR--\\\\

            //AddJugador();
            //BuscarJugador();
            //MostrarJugadores();


            ////--ACCIONES DE ARBITRO--\\\\
            
            //AddArbitro();
            //BuscarArbitro(3);
            //MostrarArbitros();


            ////--ACCIONES DE DESEMPEÑO--\\\\

            //AddDesempeño();
            //BuscarDesempeño(3);
            //MostrarDesempeño();


            ////--ACCIONES DE EQUIPO--\\\\

            //AddEquipo();
            //BuscarEquipo(3);
            //MostrarEquipo();
            //AsignarDesempeño();


            ////--ACCIONES DE NOVEDADPARTIDO--\\\\

            AddNovedadPartido();
            //BuscarNovedadPartido(3);
            //MostrarNovedadPartido();


            ////--ACCIONES DE PARTIDO--\\\\

            //AddPartido();
            //BuscarPartido(3);
            //MostrarPartido();
            //AsignarEstadio();
            //AsignarArbitro();


            ////--ACCIONES DE MUNICIPIO--\\\\

            //AddMunicipio();
            //BuscarMunicipio(3);
            //MostrarMunicipio();
            //AsignarEquipo();

            ////--ACCIONES DE ESTADIO--\\\\

            //AddEstadio();
            //BuscarEstadio(3);
            //MostrarEstadio();
            //AsignarMunicipio();
            

            ////--ACCIONES DE DIRECTORTECNICO--\\\\

            //AddDirectorTecnico();
            //BuscarDirectorTecnico(3);
            //MostrarDirectorTecnico();
        }

        ////--AGREGAR NUEVOS ELEMENTOS--\\\\

        //private static void AddJugador()
        //private static void AddArbitro()
        //private static void AddDesempeño()
        private static void AddNovedadPartido()
        //private static void AddPartido()
        //private static void AddMunicipio()
        //private static void AddEstadio()
        //private static void AddEquipo()
        //private static void AddDirectorTecnico()

        {

            ////--AGREGAR ELEMENTOS JUGADOR--\\\\

            /*var jugador = new Jugador
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
            _repoJugador.AddJugador(jugador);*/


            ////--AGREGAR ELEMENTOS ARBITRO--\\\\

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


            ////--AGREGAR ELEMENTOS DESEMPEÑO--\\\\

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


            ////--AGREGAR ELEMENTOS NOVEDADPARTIDO--\\\\

            var novedadPartido = new NovedadPartido
            {
                Novedad = "Golpe a otro jugador",
                JugadorInvolucrado = "Pepe Perez",
                TarjetasAmarillas = 2,
                TarjetasRojas = 1,
                Goles = 3,
                Minuto = 20
            };
            _repoNovedadPartido.AddNovedadPartido(novedadPartido);


            ////--AGREGAR ELEMENTOS PARTIDO--\\\\

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


            ////--AGREGAR ELEMENTOS MUNICIPIO--\\\\

            /*var municipio = new Municipio
            {
                //Id = 1020,
                NombreMunicipio = "Puerto A",
            };
            _repoMunicipio.AddMunicipio(municipio);*/


            ////--AGREGAR ELEMENTOS ESTADIO--\\\\

            /*var estadio = new Estadio
            {
                //Id = 1099,
                NombreEstadio = "Metropolitano",
                Direccion = "calle 130",
            };
            _repoEstadio.AddEstadio(estadio);*/


            ////--AGREGAR ELEMENTOS EQUIPO--\\\\

            /*var equipo = new Equipo
            {
                //Id = 1099,
                NombreEquipo = "Halcones Azules",
            };
            _repoEquipo.AddEquipo(equipo);*/


            ////--AGREGAR ELEMENTOS DIRECTORTECNICO--\\\\

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

        ////--BUSCAR ELEMENTOS--\\\\

        //private static void BuscarJugador(int idJugador)
        //private static void BuscarArbitro(int idArbitro)
        //private static void BuscarDesempeño(int idDesempeño)
        private static void BuscarNovedadPartido(int idNovedadPartido)
        //private static void BuscarPartido(int idPartido)
        //private static void BuscarMunicipio(int idMunicipio)
        //private static void BuscarEstadio(int idEstadio)
        //private static void BuscarEquipo(int idEquipo)
        //private static void BuscarDirectorTecnico(int idDirectorTecnico)
        
        {
            //var paciente = _repoPaciente.GetPaciente(idPaciente);//// --PROTOTIPO
            ///var jugador = _repoJugador.GetJugador(idJugador);//// --PROTOTIPO
            ///Console.WriteLine(jugador.Nombre+" "+jugador.Apellidos);//// --PROTOTIPO
        }

        ////--MOSTRAR ELEMENTOS--\\\\

        //private static void MostrarJugadores()
        //private static void MostrarArbitros()
        //private static void MostrarDesempeños()
        private static void MostrarNovedadesPartido()
        //private static void MostrarPartidos()
        //private static void MostrarMunicipios()
        //private static void MostrarEstadios()
        //private static void MostrarEquipos()
        //private static void MostrarDirectoresTecnicos()

        {
            ////--MOSTRAR ELEMENTOS JUGADOR--\\\\

            /*var Jugadores = _repoJugador.GetAllJugadores();
            foreach (var jugador in Jugadores)
            {
                Console.WriteLine(jugador.Nombre+" "+jugador.Apellidos);
            }*/


            ////--MOSTRAR ELEMENTOS ARBITRO--\\\\

            /*var Arbitros = _repoArbitro.GetAllArbitros();
            foreach (var arbitro in Arbitros)
            {
                Console.WriteLine(arbitro.Nombre+" "+arbitro.Apellidos);
            }*/


            ////--MOSTRAR ELEMENTOS DESEMPEÑO--\\\\

            /*var Desempeños = _repoDesempeño.GetAllDesempeños();
            foreach (var desempeño in Desempeños)
            {
                Console.WriteLine(desempeño.PartidosGanados +" "+desempeño.Puntos);             ////
            }*/


            ////--MOSTRAR ELEMENTOS JUGADOR--\\\\

            /*var NovedadPartidos = _repoNovedadPartido.GetAllNovedadPartidos();
            foreach (var novedadPartido in NovedadPartidos)
            {
                Console.WriteLine(novedadPartido.Novedad +" "+novedadPartido.JugadorInvolucrado);
            }*/


            ////--MOSTRAR ELEMENTOS PARTIDO--\\\\

            /*var Partidos = _repoPartido.GetAllPartidos();
            foreach (var partido in Partidos)
            {
                Console.WriteLine(partido.EquipoLocal +" "+partido.EquipoVisitante);
            }*/


            ////--MOSTRAR ELEMENTOS MUNICIPIO--\\\\

            /*var Municipios = _repoMunicipio.GetAllMunicipios();
            foreach (var municipio in Municipios)
            {
                Console.WriteLine(municipio.NombreMunicipio);
            }*/


            ////--MOSTRAR ELEMENTOS ESTADIO--\\\\

            /*var Estadios = _repoEstadio.GetAllEstadios();
            foreach (var estadio in Estadios)
            {
                Console.WriteLine(estadio.NombreEstadio+" "+estadio.Direccion);
            }*/


            ////--MOSTRAR ELEMENTOS EQUIPO--\\\\

            /*var Equipos = _repoEquipo.GetAllEquipos();
            foreach (var equipo in Equipos)
            {
                Console.WriteLine(equipo.NombreEquipo);
            }*/


            ////--MOSTRAR ELEMENTOS DIRECTORTECNICO--\\\\

            /*var DirectoresTecnicos = _repoDirectorTecnico.GetAllDirectoresTecnicos();
            foreach (var directorTecnico in DirectoresTecnicos)
            {
                Console.WriteLine(directorTecnico.Nombre+" "+directorTecnico.Apellidos);
            }*/


            ////--MOSTRAR ELEMENTOS NOVEDADPARTIDO--\\\\

            var NovedadesPartido = _repoNovedadPartido.GetAllNovedadesPartido();
            foreach (var novedadPartido in NovedadesPartido)
            {
                Console.WriteLine(novedadPartido.Novedad+" "+novedadPartido.JugadorInvolucrado);
            }
        }

        ////--ACCION ESPECIAL DE EQUIPO PARA ASIGNAR UN DESEMPEÑO A UN EQUIPO--\\\\

        /*private static void AsignarDesempeño()
        {
            var desempeño = _repoEquipo.AsignarDesempeño(1, 1);
            Console.WriteLine(desempeño.PartidosGanados +" "+desempeño.Puntos);   
        }*/


        ////--ACCION ESPECIAL DE MUNICIPIO PARA ASIGNAR UN EQUIPO A UN MUNICIPIO--\\\\

        /*private static void AsignarEquipo()
        {
            var equipo = _repoMunicipio.AsignarEquipo(1, 1);
            Console.WriteLine(equipo.NombreEquipo);    
        }*/


        ////--ACCION ESPECIAL DE ESTADIO PARA ASIGNAR UN MUNICIPIO A UN ESTADIO--\\\\

        /*private static void AsignarMunicipio()
        {
            var municipio = _repoEstadio.AsignarMunicipio(1, 1);
            Console.WriteLine(municipio.NombreMunicipio);    
        }*/


        ////--ACCION ESPECIAL DE PARTIDO PARA ASIGNAR UN ESTADIO A UN PARTIDO--\\\\

        /*private static void AsignarEstadio()
        {
            var estadio = _repoPartido.AsignarEstadio(1, 1);
            Console.WriteLine(estadio.NombreEstadio+" "+estadio.Direccion);    
        }*/


        ////--ACCION ESPECIAL DE PARTIDO PARA ASIGNAR UN ARBITRO A UN PARTIDO--\\\\

        /*private static void AsignarArbitro()
        {
            var arbitro = _repoPartido.AsignarArbitro(1, 3);
            Console.WriteLine(arbitro.Nombre+" "+arbitro.Apellidos);    
        }*/
    }
}





