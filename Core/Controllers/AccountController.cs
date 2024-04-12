using Core.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {

        private readonly IAccountService _accountService;
        private readonly ILogger<AccountController> _logger;
        public AccountController(ILogger<AccountController> logger, IAccountService accountService)
        {
            _logger = logger;
            _accountService = accountService;
        }


        //[HttpPost(ApiEndpoints.Account.Create)]
        public async Task<IActionResult> Create()
        {
            //инча логикаи гирифтани запросу передавать кардан ба Application ва mapping натича
            return null;
        }
    }
}
