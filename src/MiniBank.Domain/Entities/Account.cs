using MiniBank.Domain.Events;
using MiniBank.Domain.Shareds;
using System;

namespace MiniBank.Domain.Entities
{
    public class Account : Entity
    {

        public Account(int userId, string description) 
        { 
            UserId = userId;
            Description = description;
            Balance = decimal.Zero;
            Raise(new AccountEvent.AccountCreatedEvent{ AccountId = Id, UserId = UserId });
        }

        public int Id { get; }
        public int UserId { get; }
        public string Description { get; }
        public decimal  Balance { get; }
        public DateTime CreatedAt { get; }
        public DateTime UpdatedAt { get; }
    }
}
