namespace TorneoFutbolistico.App.Dominio
{
      
    public class NovedadPartido
    {
        public int Id { get; set; } 
        public string Novedad { get; set; } 
        public string JugadorInvolucrado { get; set; }
        public int TarjetasAmarillas { get; set; }
        public int TarjetasRojas { get; set; }
        public int Goles { get; set; }
        public int Minuto { get; set; }
    }
}