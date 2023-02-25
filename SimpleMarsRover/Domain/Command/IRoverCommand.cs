namespace SimpleMarsRover.Domain.Command
{
    public interface ICommandHandler<T> : ICommandHandler where T : ICommand
    {
        void Handle(T command);
    }
}