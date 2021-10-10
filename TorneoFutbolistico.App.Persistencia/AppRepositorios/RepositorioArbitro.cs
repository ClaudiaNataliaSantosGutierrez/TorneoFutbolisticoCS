using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Persistencia
{
    public class RepositorioArbitro : IRepositorioArbitro
    {
        //private readonly AppContext _appContext;
        private readonly AppContext _appContext = new AppContext();

        //public RepositorioArbitro(AppContext appContext)
        //{
        //    _appContext=appContext;
        //}

        Arbitro IRepositorioArbitro.AddArbitro(Arbitro arbitro)
        {
            var arbitroAdicionado = _appContext.Arbitros.Add(arbitro);
            _appContext.SaveChanges();
            return arbitroAdicionado.Entity; 
        }

        void IRepositorioArbitro.DeleteArbitro(int idArbitro)
        {
            var arbitroEncontrado = _appContext.Arbitros.Find(idArbitro);    //.FirstOrDefault(p => p.Id==idPaciente)
            if (arbitroEncontrado == null)
                return;
            _appContext.Arbitros.Remove(arbitroEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Arbitro> IRepositorioArbitro.GetAllArbitros()
        {
            return _appContext.Arbitros;
        }

        Arbitro IRepositorioArbitro.GetArbitro(int idArbitro)
        {
            return _appContext.Arbitros.Find(idArbitro);    //p => p.Id==idPaciente
        }

        Arbitro IRepositorioArbitro.UpdateArbitro(Arbitro arbitro)
        {
            var arbitroEncontrado = _appContext.Arbitros.Find(arbitro.id);    //Id_A //p => p.Id==paciente.Id
            if (arbitroEncontrado!=null)
            {
                arbitroEncontrado.Nombre = arbitro.Nombre;
                arbitroEncontrado.Apellidos = arbitro.Apellidos;
                arbitroEncontrado.Documento = arbitro.Documento;
                arbitroEncontrado.NumeroTelefono = arbitro.NumeroTelefono;
                arbitroEncontrado.Id_A = arbitro.Id_A;
                arbitroEncontrado.Colegio = arbitro.Colegio;

                _appContext.SaveChanges();
            }
            return arbitroEncontrado;





/*        public RepositorioArbitro(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Arbitro AddArbitro(Arbitro arbitro)      
        {
            var ArbitroAdicionado = _appContext.Arbitros.Add(arbitro);
            _appContext.SaveChanges();
            return arbitroAdicionado.Entity;
        }

        public void DeleteArbitro(int idArbitro)
        {
            var arbitroEncontrado = _appContext.Arbitros.Find(idArbitro);
            if (arbitroEncontrado == null)
                return;
            _appContext.Arbitros.Remove(arbitroEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Arbitro> GetAllArbitros()
        {
            return _appContext.Arbitros;
        }

        public Arbitro GetArbitro(int idArbitro)
        {
            return _appContext.Arbitros.Find(idArbitro);
        }

        public Arbitro UpdateArbitro(Arbitro arbitro)
        {
            var arbitroEncontrado = _appContext.Arbitros.Find(arbitro.id);    //jugador.Id
            if (arbitroEncontrado != null)
            {
                arbitroEncontrado.Nombre = arbitro.Nombre;
                arbitroEncontrado.Apellidos = arbitro.Apellidos;
                arbitroEncontrado.Documento = arbitro.Documento;
                arbitroEncontrado.NumeroTelefono = arbitro.NumeroTelefono;
                arbitroEncontrado.Id_A = arbitro.Id_A;
                arbitroEncontrado.Colegio = arbitro.Colegio;
                //arbitroEncontrado.N_equipo = jugador.N_equipo;
                //jugadorEncontrado.Equipo = jugador.Equipo;
                _appContext.SaveChanges();
            }
            return arbitroEncontrado;*/
        }
    }
}