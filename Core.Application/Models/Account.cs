using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Models
{

    public enum AccountType {Deposit, Loan }
    public class Account
    {
        public long Id { get; set; }
        public string? Number { get; set; }
        public DateTime DateOpened { get; set; }
        public required long  ClientId { get; init; }
        public required AccountType Type { get; init; }
        public required long UserId { get; init; }
        public string? BalanceAccount { get; set; }
    }
}
