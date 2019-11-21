using System.Collections.Generic;

namespace FrotaPim.Domain
{
    public interface IRepositorio<TEntity> 
    {
        TEntity ConsultarPorID(int ID);
        IEnumerable<TEntity> ObterTodos();
        void Inserir(TEntity entity);
        TEntity Editar(TEntity entity);
        void Deletar(TEntity entity);
    }
}