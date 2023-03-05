using MediatR;
using Microsoft.AspNetCore.Mvc;
using MiniBank.Application.Commands;

namespace MiniBank.Api.Controllers
{
    [Route("[controller]")]
    public class AccountsController : ApiController
    {
        private readonly ILogger<AccountsController> _logger;

        public AccountsController(ISender sender, ILogger<AccountsController> logger)
            : base(sender)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAccountCommand command, CancellationToken cancellationToken)
        {
            await Sender.Send(command, cancellationToken);

            return NoContent();
        }
    }
}