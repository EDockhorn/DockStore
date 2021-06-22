using System.Threading.Tasks;

namespace DockStore.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}