using MediatR;
using System;

namespace MiniBank.Domain.Shareds
{
    public interface IEvent : INotification
    {
        public Guid EventId { get; }
    }
}
