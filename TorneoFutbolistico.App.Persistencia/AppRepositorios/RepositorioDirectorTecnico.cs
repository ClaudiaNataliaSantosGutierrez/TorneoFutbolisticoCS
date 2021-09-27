using System.Collections.Generic;
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
            return _appContext.DirectoresTecnicos.Find(idDirectorTecnico);    //p => p.Id==idPaciente
        }

        DirectorTecnico IRepositorioDirectorTecnico.UpdateDirectorTecnico(DirectorTecnico directorTecnico)
        {
            var directorTecnicoEncontrado = _appContext.DirectoresTecnicos.Find(directorTecnico.Id_DS);   //p => p.Id==paciente.Id
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
    }
}