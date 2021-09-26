using System.Collections.Generic;
using System.Linq;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Persistencia
{
    public class RepositorioPartido : IRepositorioPartido
    {
        private readonly AppContext _appContext = new AppContext();

        Partido IRepositorioPartido.AddPartido(Partido partido)
        {
            var partidoAdicionado = _appContext.Partidos.Add(partido);
            _appContext.SaveChanges();
            return partidoAdicionado.Entity; 
        }

        void IRepositorioPartido.DeletePartido(int idPartido)
        {
            var partidoEncontrado = _appContext.Partidos.Find(idPartido);    //.FirstOrDefault(p => p.Id==idPaciente)
            if (partidoEncontrado == null)
                return;
            _appContext.Partidos.Remove(partidoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Partido> IRepositorioPartido.GetAllPartidos()
        {
            return _appContext.Partidos;
        }

        Partido IRepositorioPartido.GetPartido(int idPartido)
        {
            return _appContext.Partidos.Find(idPartido);    //p => p.Id==idPaciente
        }

        Partido IRepositorioPartido.UpdatePartido(Partido partido)
        {
            var partidoEncontrado = _appContext.Partidos.Find(partido.Id);   //p => p.Id==paciente.Id
            if (partidoEncontrado!=null)
            {
                partidoEncontrado.Id = partido.Id;
                partidoEncontrado.FechaHora = partido.FechaHora;
                partidoEncontrado.EquipoLocal = partido.EquipoLocal;
                partidoEncontrado.MarcadorLocal = partido.MarcadorLocal;
                partidoEncontrado.EquipoVisitante = partido.EquipoVisitante;                
                partidoEncontrado.MarcadorVisitante = partido.MarcadorVisitante;
                //partidoEncontrado.Estadio = partido.Estadio;
                //partidoEncontrado.Arbitro = partido.Arbitro;
                _appContext.SaveChanges();

            }
            return partidoEncontrado;
        }
    }
}


