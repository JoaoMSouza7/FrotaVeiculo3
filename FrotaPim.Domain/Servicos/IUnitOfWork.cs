using System.Threading.Tasks;

namespace FrotaPim.Domain.Servicos
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}