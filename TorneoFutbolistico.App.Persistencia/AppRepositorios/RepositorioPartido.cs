using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
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
            var partido = _appContext.Partidos
                      .Where(p => p.Id==idPartido)
                      .Include(p => p.Estadio)
                      .Include(p => p.Arbitro)
                      .FirstOrDefault();
            return partido;

            /*var partido = _appContext.Partidos
                      .Where(p => p.Id==idPartido)
                      .Include(p => p.Arbitro)
                      .FirstOrDefault();
            return partido;*/
            //return _appContext.Partidos.Find(idPartido);    //p => p.Id==idPaciente
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

        Estadio IRepositorioPartido.AsignarEstadio(int idPartido, int idEstadio)
        {
            var partidoEncontrado = _appContext.Partidos.FirstOrDefault(m => m.Id == idPartido);  ///FirstOrDefault(p => p.Id == idDesempeño);Find(idDesempeño);
            if (partidoEncontrado != null)
            {
                var estadioEncontrado = _appContext.Estadios.FirstOrDefault(p => p.Id == idEstadio);   //FirstOrDefault(m => m.Id == idEquipo);Find(idEquipo);
                if (estadioEncontrado != null)
                {
                    partidoEncontrado.Estadio = estadioEncontrado;
                    _appContext.SaveChanges();
                }
                return estadioEncontrado;
            }
            return null;
        }

        Arbitro IRepositorioPartido.AsignarArbitro(int idPartido, int idArbitro)
        {
            var partidoEncontrado = _appContext.Partidos.FirstOrDefault(m => m.Id == idPartido);  //FirstOrDefault(p => p.Id == idDesempeño);Find(idDesempeño);
            if (partidoEncontrado != null)
            {
                var arbitroEncontrado = _appContext.Arbitros.FirstOrDefault(p => p.id == idArbitro);   //FirstOrDefault(m => m.Id == idEquipo);Find(idEquipo);
                if (arbitroEncontrado != null)
                {
                    partidoEncontrado.Arbitro = arbitroEncontrado;
                    _appContext.SaveChanges();
                }
                return arbitroEncontrado;
            }
            return null;
        }
    }
}


