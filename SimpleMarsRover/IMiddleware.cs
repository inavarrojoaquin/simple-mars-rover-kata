using SimpleMarsRover.Domain.Command;

namespace SimpleMarsRover
{
    public interface IMiddleware<T> where T : ICommand
    {
        void Handle(T command);
    }
}