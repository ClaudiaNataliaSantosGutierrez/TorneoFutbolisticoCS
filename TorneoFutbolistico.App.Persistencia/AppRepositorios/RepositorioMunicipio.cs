using System.Collections.Generic;
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
            return _appContext.Municipios.Find(idMunicipio);    //p => p.Id==idPaciente
        }

        Municipio IRepositorioMunicipio.UpdateMunicipio(Municipio municipio)
        {
            var municipioEncontrado = _appContext.Municipios.Find(municipio.Id);   //p => p.Id==paciente.Id
            if (municipioEncontrado!=null)
            {
                municipioEncontrado.Id = municipio.Id;
                municipioEncontrado.NombreMunicipio  = municipio.NombreMunicipio;
                _appContext.SaveChanges();
            }
            return municipioEncontrado;
        }
    }
}