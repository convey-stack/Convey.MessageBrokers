using System;
using System.Threading.Tasks;
using Convey.Types;

namespace Convey.MessageBrokers
{
    public interface IBusSubscriber
    {
        IBusSubscriber Subscribe<TMessage>(Func<IServiceProvider, TMessage, ICorrelationContext, Task> handle,
            Func<TMessage, Exception, object> onError = null) where TMessage : class;
    }
}
