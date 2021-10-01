using System.Collections.Generic;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Persistencia
{
    public interface IRepositorioPartido
    {
        IEnumerable<Partido> GetAllPartidos();
        Partido AddPartido(Partido partido);
        Partido UpdatePartido(Partido partido);
        void DeletePartido(int idpartido);    
        Partido GetPartido(int idpartido);
        Estadio AsignarEstadio(int idPartido, int idEstadio);
        Arbitro AsignarArbitro(int idPartido, int idArbitro);
    }
}