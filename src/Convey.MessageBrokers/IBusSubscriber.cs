using System;
using System.Threading.Tasks;

namespace Convey.MessageBrokers
{
    public interface IBusSubscriber
    {
        IBusSubscriber Subscribe<TMessage>(Func<IServiceProvider, TMessage, ICorrelationContext, Task> handle)
            where TMessage : class;
    }
}
