using Core.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Services
{
    public class AccountService:IAccountService
    {
        public AccountService() 
        {
        
        }

        public Task<Account> CreateAsync(Account account)
        {
            //инча репозиторию дальше . ман барои осони жестко дар код мемонам
            account.BalanceAccount = "20216";
            account.DateOpened = DateTime.Now;
            account.Number = $"{account.BalanceAccount}972{Random.Shared.Next(10000000, 100000000)}";
            return Task.FromResult(account);
        }
    }
}
