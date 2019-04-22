using System.Threading;

namespace Convey.MessageBrokers
{
    public class CorrelationContextAccessor : ICorrelationContextAccessor
    {
        private static AsyncLocal<CorrelationContextHolder> _correlationContextCurrent = new AsyncLocal<CorrelationContextHolder>();

        public ICorrelationContext CorrelationContext
        {
            get => _correlationContextCurrent.Value?.Context;
            set
            {
                var holder = _correlationContextCurrent.Value;
                if (holder != null)
                {
                    holder.Context = null;
                }

                if (value != null)
                {
                    _correlationContextCurrent.Value = new CorrelationContextHolder { Context = value };
                }
            }
        }

        private class CorrelationContextHolder
        {
            public ICorrelationContext Context;
        }
    }
}