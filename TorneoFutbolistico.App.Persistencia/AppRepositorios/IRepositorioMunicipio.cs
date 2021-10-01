using System.Collections.Generic;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Persistencia
{
    public interface IRepositorioMunicipio
    {
        IEnumerable<Municipio> GetAllMunicipios();
        Municipio AddMunicipio(Municipio municipio);
        Municipio UpdateMunicipio(Municipio municipio);
        void DeleteMunicipio(int idMunicipio);    
        Municipio GetMunicipio(int idMunicipio);
        Equipo AsignarEquipo(int idMunicipio, int idEquipo);
    }
}



