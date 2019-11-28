using System.Collections.Generic;
using System.Linq;
using FrotaPim.Data;
using FrotaPim.Domain;

namespace FrotaPim.Data
{
    public class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity : Entidade
    {
        protected readonly ApplicationDbContext _context;

        public Repositorio(ApplicationDbContext context)
        {
            _context = context;
        }
        public virtual TEntity ConsultarPorID(int ID)
        {
            return _context.Set<TEntity>().SingleOrDefault(e => e.Id == ID);
        }

        public void Deletar(TEntity entity)
        {
            _context.Remove(entity);
        }
        public TEntity Editar(TEntity entity)
        {
             _context.Update(entity);
             return entity;
        }
        public virtual void Inserir(TEntity entidade)
        {
            _context.Set<TEntity>().Add(entidade);
        }
        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return _context.Set<TEntity>().AsEnumerable();
        }
    }
}