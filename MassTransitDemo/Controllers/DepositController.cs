using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Core.Shared;
namespace MassTransitDemo.Controllers
{
    [ApiController]
    public class DepositController : ControllerBase
    {
        private readonly IPublishEndpoint _publishEndpoint;

        private readonly ILogger<DepositController> _logger;

        public DepositController(ILogger<DepositController> logger, IPublishEndpoint publishEndpoint)
        {
            _logger = logger;
            _publishEndpoint = publishEndpoint;
        }

        [HttpPost("api/deposit/create")]
        public async Task<Model.Deposit> Create([FromBody] Model.DepositRequest depositRequest)
        {
            //Дар проекти асоси инча вызови сервис аз проекти Deposit.Application мешавад
            CreateAccount createAccount = new CreateAccount() {ClientId=122121, UserId = 1233, AccountType = AccountType.Deposit   };
            await _publishEndpoint.Publish(createAccount);
            Model.Deposit deposit = new Model.Deposit() { Amount= depositRequest.Amount, Code="IO-DS-001", State = Model.ObjectStates.New };
            
            return deposit;
        }
    }
}
