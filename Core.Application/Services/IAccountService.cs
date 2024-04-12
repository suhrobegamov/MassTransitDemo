using Core.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Services
{
    public interface IAccountService
    {
        Task<Account> CreateAsync(Account account);

    }
}
