using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Persistencia
{
    public class RepositorioDirectorTecnico : IRepositorioDirectorTecnico
    {
        private readonly AppContext _appContext = new AppContext();

        DirectorTecnico IRepositorioDirectorTecnico.AddDirectorTecnico(DirectorTecnico directorTecnico)
        {
            var directorTecnicoAdicionado = _appContext.DirectoresTecnicos.Add(directorTecnico);
            _appContext.SaveChanges();
            return directorTecnicoAdicionado.Entity; 
        }

        void IRepositorioDirectorTecnico.DeleteDirectorTecnico(int idDirectorTecnico)
        {
            var directorTecnicoEncontrado = _appContext.DirectoresTecnicos.Find(idDirectorTecnico);    //.FirstOrDefault(p => p.Id==idPaciente)
            if (directorTecnicoEncontrado == null)
                return;
            _appContext.DirectoresTecnicos.Remove(directorTecnicoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<DirectorTecnico> IRepositorioDirectorTecnico.GetAllDirectoresTecnicos()
        {
            return _appContext.DirectoresTecnicos;
        }

        DirectorTecnico IRepositorioDirectorTecnico.GetDirectorTecnico(int idDirectorTecnico)
        {
            var directorTecnico = _appContext.DirectoresTecnicos
                      .Where(p => p.id==idDirectorTecnico)
                      .Include(p => p.Equipo)
                      .FirstOrDefault();
            return directorTecnico;
            //return _appContext.DirectoresTecnicos.Find(idDirectorTecnico);    ///p => p.Id==idPaciente
        }

        DirectorTecnico IRepositorioDirectorTecnico.UpdateDirectorTecnico(DirectorTecnico directorTecnico)
        {
            var directorTecnicoEncontrado = _appContext.DirectoresTecnicos.Find(directorTecnico.id);   //p => p.Id==paciente.Id
            if (directorTecnicoEncontrado!=null)
            {
                directorTecnicoEncontrado.Nombre = directorTecnico.Nombre;
                directorTecnicoEncontrado.Apellidos = directorTecnico.Apellidos;
                directorTecnicoEncontrado.Documento = directorTecnico.Documento;
                directorTecnicoEncontrado.NumeroTelefono = directorTecnico.NumeroTelefono;
                directorTecnicoEncontrado.Id_DS  = directorTecnico.Id_DS;
                _appContext.SaveChanges();
            }
            return directorTecnicoEncontrado;
        }

        Equipo IRepositorioDirectorTecnico.AsignarEquipo(int idDirectorTecnico, int idEquipo)
        {
            var directorTecnicoEncontrado = _appContext.DirectoresTecnicos.FirstOrDefault(m => m.id == idDirectorTecnico);
            if (directorTecnicoEncontrado != null)
            {
                var equipoEncontrado = _appContext.Equipos.FirstOrDefault(p => p.Id == idEquipo);   //FirstOrDefault(m => m.Id == idEquipo);Find(idEquipo);
                if (equipoEncontrado != null)
                {
                    directorTecnicoEncontrado.Equipo = equipoEncontrado;
                    _appContext.SaveChanges();
                }
                return equipoEncontrado;
            }
            return null;
        }
        
    }
}