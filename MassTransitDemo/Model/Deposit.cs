namespace MassTransitDemo.Model
{
    public enum ObjectStates {New, WaitConf, Completed }
    public class Deposit
    {
        public required string Code { get; init; }
        public string Account { get; init; }
        public required decimal Amount { get; init; }
        public required ObjectStates State { get; init; }
    }
}
