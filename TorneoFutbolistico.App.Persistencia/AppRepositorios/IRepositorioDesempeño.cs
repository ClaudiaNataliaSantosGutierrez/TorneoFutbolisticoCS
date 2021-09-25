using System.Collections.Generic;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Persistencia
{
    public interface IRepositorioDesempeño
    {
        IEnumerable<Desempeño> GetAllDesempeños();
        Desempeño AddDesempeño(Desempeño Desempeño);
        Desempeño UpdateDesempeño(Desempeño Desempeño);
        void DeleteDesempeño(int idDesempeño);    
        Desempeño GetDesempeño(int idDesempeño); 
    }
}


