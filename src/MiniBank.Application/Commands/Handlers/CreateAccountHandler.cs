using MediatR;
using MiniBank.Domain.Entities;
using MiniBank.Domain.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace MiniBank.Application.Commands.Handlers
{
    public class CreateAccountHandler : IRequestHandler<CreateAccountCommand>
    {
        private readonly IAccountRepository _accountRepository;

        public CreateAccountHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<Unit> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
            var account = new Account(request.UserId, request.Description);

            await _accountRepository.CreateAccountAsync(account);

            return Unit.Value;
        }
    }
}
