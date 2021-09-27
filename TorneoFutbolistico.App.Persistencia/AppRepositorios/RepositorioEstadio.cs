using System.Collections.Generic;
using System.Linq;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Persistencia
{
    public class RepositorioEstadio : IRepositorioEstadio
    {
        private readonly AppContext _appContext = new AppContext();

        Estadio IRepositorioEstadio.AddEstadio(Estadio estadio)
        {
            var estadioAdicionado = _appContext.Estadios.Add(estadio);
            _appContext.SaveChanges();
            return estadioAdicionado.Entity; 
        }

        void IRepositorioEstadio.DeleteEstadio(int idEstadio)
        {
            var estadioEncontrado = _appContext.Estadios.Find(idEstadio);    //.FirstOrDefault(p => p.Id==idPaciente)
            if (estadioEncontrado == null)
                return;
            _appContext.Estadios.Remove(estadioEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Estadio> IRepositorioEstadio.GetAllEstadios()
        {
            return _appContext.Estadios;
        }

        Estadio IRepositorioEstadio.GetEstadio(int idEstadio)
        {
            return _appContext.Estadios.Find(idEstadio);    //p => p.Id==idPaciente
        }

        Estadio IRepositorioEstadio.UpdateEstadio(Estadio estadio)
        {
            var estadioEncontrado = _appContext.Estadios.Find(estadio.Id);   //p => p.Id==paciente.Id
            if (estadioEncontrado!=null)
            {
                //estadioEncontrado.Id  = estadio.Id;
                estadioEncontrado.NombreEstadio = estadio.NombreEstadio;
                estadioEncontrado.Direccion = estadio.Direccion;
                _appContext.SaveChanges();
            }
            return estadioEncontrado;
        }
    }
}
