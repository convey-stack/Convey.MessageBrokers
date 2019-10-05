using System;
using System.Threading.Tasks;

namespace Convey.MessageBrokers
{
    public interface ISubscriber
    {
        ISubscriber Subscribe<T>(Func<IServiceProvider, T, ICorrelationContext, Task> handle) where T : class;
    }
}
