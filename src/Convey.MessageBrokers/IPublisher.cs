using System.Threading.Tasks;

namespace Convey.MessageBrokers
{
    public interface IPublisher
    {
        Task PublishAsync<T>(T message, ICorrelationContext context = null) where T : class;
    }
}