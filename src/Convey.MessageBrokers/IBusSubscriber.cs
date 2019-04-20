using System;
using System.Threading.Tasks;
using Convey.Types;

namespace Convey.MessageBrokers
{
    public interface IBusSubscriber
    {
        IBusSubscriber SubscribeMessage<TMessage>(Func<IServiceProvider, TMessage, ICorrelationContext, Task> handle, 
            string @namespace = null, string queueName = null, Func<TMessage, ConveyException, object> onError = null) 
            where TMessage : class;
    }
}
