using MediatR;
using Microsoft.AspNetCore.Mvc;

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
    }
}