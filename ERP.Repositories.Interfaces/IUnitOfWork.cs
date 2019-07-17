using ERP.Utility;
using System.Threading.Tasks;
namespace ERP.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<T> Repository<T>() where T : class;

        Task<TransResult<int>> Commit();

        void Rollback();
    }
}
