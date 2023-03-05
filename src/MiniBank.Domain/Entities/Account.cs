using System;

namespace MiniBank.Domain.Entities
{
    public class Account
    {

        public Account(int userId, string description) 
        { 
            UserId = userId;
            Description = description;
            Balance = decimal.Zero;
        }

        public int Id { get; }
        public int UserId { get; }
        public string Description { get; }
        public decimal  Balance { get; }
        public DateTime CreatedAt { get; }
        public DateTime UpdatedAt { get; }
    }
}
