using System.Collections.Generic;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Persistencia
{
    public interface IRepositorioArbitro
    {
        IEnumerable<Arbitro> GetAllArbitros();
        Arbitro AddArbitro(Arbitro arbitro);
        Arbitro UpdateArbitro(Arbitro arbitro);
        void DeleteArbitro(int idArbitro);    
        Arbitro GetArbitro(int idArbitro);
        IEnumerable<Arbitro> SearchArbitros(string nombre);
    }
}