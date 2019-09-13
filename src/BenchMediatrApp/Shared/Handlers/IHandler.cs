using BenchMediatrApp.Shared.Commands;

namespace BenchMediatrApp.Shared.Handlers
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}