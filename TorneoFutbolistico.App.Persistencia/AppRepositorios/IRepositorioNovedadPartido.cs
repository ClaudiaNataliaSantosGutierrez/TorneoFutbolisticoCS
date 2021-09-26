using System.Collections.Generic;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Persistencia
{
    public interface IRepositorioNovedadPartido
    {
        IEnumerable<NovedadPartido> GetAllNovedadPartidos();
        NovedadPartido AddNovedadPartido(NovedadPartido novedadPartido);
        NovedadPartido UpdateNovedadPartido(NovedadPartido novedadPartido);
        void DeleteNovedadPartido(int idNovedadPartido);    
        NovedadPartido GetNovedadPartido(int idNovedadPartido);
    }
}