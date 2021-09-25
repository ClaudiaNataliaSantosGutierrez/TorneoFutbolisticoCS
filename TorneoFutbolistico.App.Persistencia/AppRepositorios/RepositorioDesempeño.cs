using System.Collections.Generic;
using System.Linq;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Persistencia
{
    public class RepositorioDesempeño : IRepositorioDesempeño
    {
        //private readonly AppContext _appContext;
        private readonly AppContext _appContext = new AppContext();

        //public RepositorioDesempeño(AppContext appContext)
        //{
          //  _appContext = appContext;
        //}

        Desempeño IRepositorioDesempeño.AddDesempeño(Desempeño desempeño)
        {
            var desempeñoAdicionado = _appContext.Desempeños.Add(desempeño);
            _appContext.SaveChanges();
            return desempeñoAdicionado.Entity; 
        }

        void IRepositorioDesempeño.DeleteDesempeño(int idDesempeño)
        {
            var desempeñoEncontrado = _appContext.Desempeños.Find(idDesempeño);    //.FirstOrDefault(p => p.Id==idPaciente)
            if (desempeñoEncontrado == null)
                return;
            _appContext.Desempeños.Remove(desempeñoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Desempeño> IRepositorioDesempeño.GetAllDesempeños()
        {
            return _appContext.Desempeños;
        }

        Desempeño IRepositorioDesempeño.GetDesempeño(int idDesempeño)
        {
            return _appContext.Desempeños.Find(idDesempeño);    //p => p.Id==idPaciente
        }

        Desempeño IRepositorioDesempeño.UpdateDesempeño(Desempeño desempeño)
        {
            var desempeñoEncontrado = _appContext.Desempeños.Find(desempeño.Id);   //p => p.Id==paciente.Id
            if (desempeñoEncontrado!=null)
            {
                //desempeñoEncontrado.Id = desempeño.Id;
                desempeñoEncontrado.PartidosJugados = desempeño.PartidosJugados;
                desempeñoEncontrado.PartidosGanados = desempeño.PartidosGanados;
                desempeñoEncontrado.PartidosEmpatados = desempeño.PartidosEmpatados;
                desempeñoEncontrado.PartidosPerdidos = desempeño.PartidosPerdidos;                
                desempeñoEncontrado.GolesFavor = desempeño.GolesFavor;
                desempeñoEncontrado.GolesContra = desempeño.GolesContra;
                desempeñoEncontrado.Puntos = desempeño.Puntos;


                _appContext.SaveChanges();
            }
            return desempeñoEncontrado;
        }
    }
}
