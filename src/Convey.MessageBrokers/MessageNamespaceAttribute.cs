using System;

namespace Convey.MessageBrokers
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MessageNamespaceAttribute : Attribute
    {
        public string Namespace { get; }
        public bool External { get; }

        public MessageNamespaceAttribute(string @namespace, bool external = true)
        {
            Namespace = @namespace?.ToLowerInvariant();
            External = external;
        }
    }
}