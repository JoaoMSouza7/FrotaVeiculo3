using System.Linq;
using FrotaPim.Data;
using FrotaPim.Domain;

namespace FrotaPim.Data
{
    public class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity : Entidade
    {
        private readonly ApplicationDbContext _context;

        public Repositorio(ApplicationDbContext context)
        {
            _context = context;
        }
        public TEntity ConsultarPorID(int ID)
        {
            return _context.Set<TEntity>().SingleOrDefault(e => e.Id == ID);
        }

        public TEntity ConsultarPorNome(string nome)
        {
            throw new System.NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new System.NotImplementedException();
        }

        public TEntity Editar(TEntity entidade)
        {
            throw new System.NotImplementedException();
        }

        public void Inserir(TEntity entidade)
        {
            _context.Set<TEntity>().Add(entidade);
        }
    }
}