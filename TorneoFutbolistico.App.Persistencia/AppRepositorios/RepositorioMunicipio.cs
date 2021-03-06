using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Persistencia
{
    public class RepositorioMunicipio : IRepositorioMunicipio
    {
        private readonly AppContext _appContext = new AppContext();

        Municipio IRepositorioMunicipio.AddMunicipio(Municipio municipio)
        {
            var municipioAdicionado = _appContext.Municipios.Add(municipio);
            _appContext.SaveChanges();
            return municipioAdicionado.Entity; 
        }

        void IRepositorioMunicipio.DeleteMunicipio(int idMunicipio)
        {
            var municipioEncontrado = _appContext.Municipios.Find(idMunicipio);    //.FirstOrDefault(p => p.Id==idPaciente)
            if (municipioEncontrado == null)
                return;
            _appContext.Municipios.Remove(municipioEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Municipio> IRepositorioMunicipio.GetAllMunicipios()
        {
            return _appContext.Municipios;
        }

        Municipio IRepositorioMunicipio.GetMunicipio(int idMunicipio)
        {
            var municipio = _appContext.Municipios
                      .Where(p => p.Id==idMunicipio)
                      .Include(p => p.Equipo)
                      .FirstOrDefault();
            return municipio;
            //return _appContext.Municipios.Find(idMunicipio);    //p => p.Id==idPaciente
        }

        Municipio IRepositorioMunicipio.UpdateMunicipio(Municipio municipio)
        {
            var municipioEncontrado = _appContext.Municipios.Find(municipio.Id);  //municipio.Id //p => p.Id==paciente.Id
            if (municipioEncontrado!=null)
            {
                //municipioEncontrado.Id = municipio.Id;
                municipioEncontrado.NombreMunicipio  = municipio.NombreMunicipio;
                _appContext.SaveChanges();
            }
            return municipioEncontrado;
        }

        Equipo IRepositorioMunicipio.AsignarEquipo(int idMunicipio, int idEquipo)
        {
            var municipioEncontrado = _appContext.Municipios.FirstOrDefault(m => m.Id == idMunicipio);  //FirstOrDefault(p => p.Id == idDesempe??o);Find(idDesempe??o);
            if (municipioEncontrado != null)
            {
                var equipoEncontrado = _appContext.Equipos.FirstOrDefault(p => p.Id == idEquipo);   //FirstOrDefault(m => m.Id == idEquipo);Find(idEquipo);
                if (equipoEncontrado != null)
                {
                    municipioEncontrado.Equipo = equipoEncontrado;
                    _appContext.SaveChanges();
                }
                return equipoEncontrado;
            }
            return null;
        }

        IEnumerable<Municipio> IRepositorioMunicipio.SearchMunicipios(string nombreMunicipio)
        {
            return _appContext.Municipios
                        .Where(p => p.NombreMunicipio.Contains(nombreMunicipio));
        }
    }
}
