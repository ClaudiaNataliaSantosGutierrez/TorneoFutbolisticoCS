using System.Collections.Generic;
using System.Linq;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Persistencia
{
    public class RepositorioNovedadPartido : IRepositorioNovedadPartido
    {
        //private readonly AppContext _appContext;
        private readonly AppContext _appContext = new AppContext();

        //public RepositorioNovedadPartido(AppContext appContext)
        //{
         //   _appContext=appContext;
        //}

        NovedadPartido IRepositorioNovedadPartido.AddNovedadPartido(NovedadPartido novedadPartido)
        {
            var novedadPartidoAdicionado = _appContext.NovedadesPartido.Add(novedadPartido);
            _appContext.SaveChanges();
            return novedadPartidoAdicionado.Entity; 
        }

        void IRepositorioNovedadPartido.DeleteNovedadPartido(int idNovedadPartido)
        {
            var novedadPartidoEncontrado = _appContext.NovedadesPartido.Find(idNovedadPartido);    //.FirstOrDefault(p => p.Id==idPaciente)
            if (novedadPartidoEncontrado == null)
                return;
            _appContext.NovedadesPartido.Remove(novedadPartidoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<NovedadPartido> IRepositorioNovedadPartido.GetAllNovedadesPartido()
        {
            return _appContext.NovedadesPartido;
        }

        NovedadPartido IRepositorioNovedadPartido.GetNovedadPartido(int idNovedadPartido)
        {
            return _appContext.NovedadesPartido.Find(idNovedadPartido);    //p => p.Id==idPaciente
        }

        NovedadPartido IRepositorioNovedadPartido.UpdateNovedadPartido(NovedadPartido novedadPartido)
        {
            var novedadPartidoEncontrado = _appContext.NovedadesPartido.Find(novedadPartido.Id);   //p => p.Id==paciente.Id
            if (novedadPartidoEncontrado!=null)
            {
                //novedadPartidoEncontrado.Id = novedadPartido.Id;
                novedadPartidoEncontrado.Novedad = novedadPartido.Novedad;
                novedadPartidoEncontrado.JugadorInvolucrado = novedadPartido.JugadorInvolucrado;
                novedadPartidoEncontrado.TarjetasAmarillas = novedadPartido.TarjetasAmarillas;
                novedadPartidoEncontrado.TarjetasRojas = novedadPartido.TarjetasRojas;                
                novedadPartidoEncontrado.Goles = novedadPartido.Goles;
                novedadPartidoEncontrado.Minuto = novedadPartido.Minuto;

                _appContext.SaveChanges();
            }
            return novedadPartidoEncontrado;
        }
    }
}

