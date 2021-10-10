using System.Collections.Generic;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Persistencia
{
    public interface IRepositorioDirectorTecnico
    {
        IEnumerable<DirectorTecnico> GetAllDirectoresTecnicos();
        DirectorTecnico AddDirectorTecnico(DirectorTecnico directorTecnico);
        DirectorTecnico UpdateDirectorTecnico(DirectorTecnico directorTecnico);
        void DeleteDirectorTecnico(int idDirectorTecnico);    
        DirectorTecnico GetDirectorTecnico(int idDirectorTecnico); 
        Equipo AsignarEquipo(int idDirectorTecnico, int idEquipo);
    }
}

