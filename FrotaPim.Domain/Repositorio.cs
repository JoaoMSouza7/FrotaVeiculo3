namespace FrotaPim.Domain
{
    public interface IRepositorio<TEntidade>
    {
        TEntidade ConsultarPorID(int ID);
        void Inserir(TEntidade entidade);
    }
}