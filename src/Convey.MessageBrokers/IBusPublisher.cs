using System.Threading.Tasks;

namespace Convey.MessageBrokers
{
    public interface IBusPublisher
    {
        Task PublishAsync<TMessage>(TMessage message, ICorrelationContext context)
            where TMessage : IMessage;
    }
}