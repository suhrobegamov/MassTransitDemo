namespace Core.Shared
{
    public class AccountCreated
    {
        public required long ClientId { get; init; }
        public required long UserId { get; init; }
        public required string Number { get; init; }
        public required string BalanceAccount { get; init; }
        public required DateTime OpenedDate { get; init; }
        public required AccountType AccountType { get; init; }
    }
}
