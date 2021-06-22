using DockStore.Core.Messages;
using System.Threading.Tasks;

namespace DockStore.Core.Bus
{
    public interface IMediatrHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
    }
}