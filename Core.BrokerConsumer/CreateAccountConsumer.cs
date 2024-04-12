using Core.Application.Services;
using Core.Shared;
using MassTransit;

namespace Core.Consumers
{
    internal class CreateAccountConsumer : IConsumer<CreateAccount>
    {
        private IAccountService _accountService;
        private readonly IPublishEndpoint _publishEndpoint;
        public CreateAccountConsumer(IAccountService accountService, IPublishEndpoint publishEndpoint)
        { 
            _accountService = accountService;
            _publishEndpoint = publishEndpoint;
        }
        public async Task Consume(ConsumeContext<CreateAccount> context)
        {
            Console.WriteLine($"Received: {context.Message.ClientId}");
            var account = await _accountService.CreateAsync(new Application.Models.Account() { UserId = context.Message.UserId, ClientId = context.Message.ClientId, Type = (Core.Application.Models.AccountType)context.Message.AccountType });
            AccountCreated accountCreated = new AccountCreated() { 
                AccountType = (Core.Shared.AccountType)account.Type, BalanceAccount=account.BalanceAccount, ClientId= account.ClientId, Number=account.Number, OpenedDate=account.DateOpened, UserId=account.UserId };
            await _publishEndpoint.Publish(accountCreated);
        }
    }
}
