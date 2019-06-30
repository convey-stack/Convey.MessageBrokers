using System;

namespace Convey.MessageBrokers
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MessageNamespaceAttribute : Attribute
    {
        public string Namespace { get; }
        public string Key { get; }
        public bool External { get; }

        public MessageNamespaceAttribute(string @namespace, string key = null, bool external = true)
        {
            Namespace = @namespace?.ToLowerInvariant();
            Key = key;
            External = external;
        }
    }
}