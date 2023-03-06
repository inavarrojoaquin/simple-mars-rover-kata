namespace SimpleMarsRover.Domain.Command
{
    public interface ICommandHandler<T> where T : ICommand
    {
        void Handle(T command);
    }
}