using Microsoft.AspNetCore.Mvc;

namespace MiniBank.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccoountsController : ControllerBase
    {
        private readonly ILogger<AccoountsController> _logger;

        public AccoountsController(ILogger<AccoountsController> logger)
        {
            _logger = logger;
        }
    }
}