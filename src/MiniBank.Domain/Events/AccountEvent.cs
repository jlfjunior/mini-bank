using MiniBank.Domain.Shareds;
using System;

namespace MiniBank.Domain.Events
{
    public static class AccountEvent
    {
        public class AccountCreatedEvent : IEvent
        {
            public Guid EventId { get; } = Guid.NewGuid();
            public int AccountId { get; set; }
            public int UserId { get; set; }
        }
    }
}
