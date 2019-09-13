namespace BenchMediatrApp.Shared.Commands
{
    public class CommandResult : ICommandResult
    {
        public CommandResult(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}