using System.Threading.Tasks;

namespace Convey.MessageBrokers
{
    public interface IPublisher
    {
        Task PublishAsync<T>(T message, string messageId = null, string correlationId = null,
            object context = null) where T : class;
    }
}