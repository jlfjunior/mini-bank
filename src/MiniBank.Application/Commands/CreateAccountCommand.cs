using MediatR;

namespace MiniBank.Application.Commands
{
    public sealed class CreateAccountCommand : IRequest
    {
        public int UserId { get; set; } 
        public string Description { get; set; } = string.Empty; 
    }      
}
