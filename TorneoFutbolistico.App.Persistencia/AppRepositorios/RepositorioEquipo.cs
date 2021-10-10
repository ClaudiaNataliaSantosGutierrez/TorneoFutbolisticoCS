using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TorneoFutbolistico.App.Dominio;

using TorneoFutbolistico.App.Persistencia;

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
            var equipo = _appContext.Equipos
                      .Where(p => p.Id==idEquipo)
                      .Include(p => p.Desempeño)
                      .FirstOrDefault();
            return equipo;
            //return _appContext.Equipos.Find(idEquipo);    //p => p.Id==idPaciente
        }

        Equipo IRepositorioEquipo.UpdateEquipo(Equipo equipo)
        {
            var equipoEncontrado = _appContext.Equipos.Find(equipo.Id);   //p => p.Id==paciente.Id
            if (equipoEncontrado!=null)
            {
                equipoEncontrado.Id  = equipo.Id;
                equipoEncontrado.NombreEquipo = equipo.NombreEquipo;

                ///desempeñoEncontrado.Desempeño = desempeñoEncontrado.Desempeño;    /////

                _appContext.SaveChanges();
            }
            return equipoEncontrado;
        }

        Desempeño IRepositorioEquipo.AsignarDesempeño(int idEquipo, int idDesempeño)
        {
            var equipoEncontrado = _appContext.Equipos.FirstOrDefault(m => m.Id == idEquipo);  //FirstOrDefault(p => p.Id == idDesempeño);Find(idDesempeño);
            if (equipoEncontrado != null)
            {
                var desempeñoEncontrado = _appContext.Desempeños.FirstOrDefault(p => p.Id == idDesempeño);   //FirstOrDefault(m => m.Id == idEquipo);Find(idEquipo);
                if (desempeñoEncontrado != null)
                {
                    equipoEncontrado.Desempeño = desempeñoEncontrado;
                    _appContext.SaveChanges();
                }
                return desempeñoEncontrado;
            }
            return null;
        }

        IEnumerable<Equipo> IRepositorioEquipo.SearchEquipos(string nombreEquipo)
        {
            return _appContext.Equipos
                        .Where(p => p.NombreEquipo.Contains(nombreEquipo));
        }
    }
}