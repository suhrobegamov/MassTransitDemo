namespace Core.Shared
{
    public class CreateAccount
    {
        public required long ClientId { get; init; }
        public required long UserId { get; init; }
        public required AccountType AccountType { get; init; }
    }
}
