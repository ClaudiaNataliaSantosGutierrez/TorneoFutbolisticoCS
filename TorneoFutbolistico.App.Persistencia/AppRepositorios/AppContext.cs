using Microsoft.EntityFrameworkCore;
using TorneoFutbolistico.App.Dominio;
namespace TorneoFutbolistico.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Arbitro> Arbitros { get; set; }
        public DbSet<Desempeño> Desempeños { get; set; }
        public DbSet<DirectorTecnico> DirectoresTecnicos { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<NovedadPartido> NovedadPartidos { get; set; }
        public DbSet<Partido> Partidos { get; set; }
        public DbSet<Estadio> Estadios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TorneoFutbolisticoDataG6");
            }
        }

    }
}