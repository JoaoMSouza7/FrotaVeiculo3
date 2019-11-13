namespace FrotaPim.Domain
{
    public interface IRepositorio<TEntidade> 
    {
        TEntidade ConsultarPorID(int ID);
        TEntidade ConsultarPorNome(string nome);
        void Inserir(TEntidade entidade);
        TEntidade Editar (TEntidade entidade);
        void Deletar(int id);
    }
}