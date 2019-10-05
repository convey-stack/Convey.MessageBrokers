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
        public bool External { get; }

        public MessageAttribute(string exchange = null, string routingKey = null, string queue = null,
            string exchangeType = null,  bool external = false)
        {
            Exchange = exchange;
            RoutingKey = routingKey;
            Queue = queue;
            ExchangeType = exchangeType;
            External = external;
        }
    }
}