using System.Collections.Generic;
using System.Linq;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Persistencia
{
    public class RepositorioEquipo : IRepositorioEquipo
    {
        private readonly AppContext _appContext = new AppContext();

        Equipo IRepositorioEquipo.AddEquipo(Equipo equipo)
        {
            var equipoAdicionado = _appContext.Equipos.Add(equipo);
            _appContext.SaveChanges();
            return equipoAdicionado.Entity; 
        }

        void IRepositorioEquipo.DeleteEquipo(int idEquipo)
        {
            var equipoEncontrado = _appContext.Equipos.Find(idEquipo);    //.FirstOrDefault(p => p.Id==idPaciente)
            if (equipoEncontrado == null)
                return;
            _appContext.Equipos.Remove(equipoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Equipo> IRepositorioEquipo.GetAllEquipos()
        {
            return _appContext.Equipos;
        }

        Equipo IRepositorioEquipo.GetEquipo(int idEquipo)
        {
            return _appContext.Equipos.Find(idEquipo);    //p => p.Id==idPaciente
        }

        Equipo IRepositorioEquipo.UpdateEquipo(Equipo equipo)
        {
            var equipoEncontrado = _appContext.Equipos.Find(equipo.Id);   //p => p.Id==paciente.Id
            if (equipoEncontrado!=null)
            {
                equipoEncontrado.Id  = equipo.Id;
                equipoEncontrado.NombreEquipo = equipo.NombreEquipo;
                _appContext.SaveChanges();
            }
            return equipoEncontrado;
        }
    }
}