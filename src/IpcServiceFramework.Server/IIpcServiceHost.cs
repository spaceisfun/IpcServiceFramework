using System.Threading;
using System.Threading.Tasks;

namespace IpcServiceFramework
{
    public interface IIpcServiceHost
    {
        void Run();

        Task RunAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
