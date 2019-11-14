namespace FrotaPim.Domain
{
    public interface IRepositorio<TEntidade> 
    {
        TEntidade ConsultarPorID(int ID);
        void Inserir(TEntidade entidade);
        TEntidade Editar (TEntidade entidade);
        void Deletar(int id);
    }
}