using System;

namespace Convey.MessageBrokers
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MessageAttribute : Attribute
    {
        public string Exchange { get; }
        public string RoutingKey { get; }
        public string Queue { get; }
        public string ExchangeType { get; }
        public bool DeclareExchange { get; }
        public bool DurableExchange { get; }
        public bool AutoDeleteExchange { get; }
        public bool External { get; }

        public MessageAttribute(string exchange, string routingKey, string queue, string exchangeType,
            bool declareExchange, bool durableExchange, bool autoDeleteExchange, bool external)
        {
            Exchange = exchange;
            RoutingKey = routingKey;
            Queue = queue;
            ExchangeType = exchangeType;
            DeclareExchange = declareExchange;
            DurableExchange = durableExchange;
            AutoDeleteExchange = autoDeleteExchange;
            External = external;
        }
    }
}