using System;

namespace MiniBank.Domain.Shareds
{
    public interface IEvent
    {
        public Guid EventId { get; }
    }
}
