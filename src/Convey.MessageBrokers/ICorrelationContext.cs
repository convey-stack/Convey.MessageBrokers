namespace Convey.MessageBrokers
{
    public interface ICorrelationContext
    {
        string CorrelationId { get; set; }
        string SpanContext { get; set; }
        int Retries { get; set; }
    }
}
