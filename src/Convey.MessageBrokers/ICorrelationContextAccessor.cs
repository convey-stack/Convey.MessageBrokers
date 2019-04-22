namespace Convey.MessageBrokers
{
    public interface ICorrelationContextAccessor
    {
        ICorrelationContext CorrelationContext { get; set; }
    }
}