namespace SimpleMarsRover.Domain.Command
{
    public interface ICommandHandlerT<T> where T : ICommand
    {
        void Handle(T command);
    }
}