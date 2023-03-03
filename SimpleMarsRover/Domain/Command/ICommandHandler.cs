namespace SimpleMarsRover.Domain.Command
{
    public interface ICommandHandler
    {
        void SetNextHandler(ICommandHandler nextHandler);
        void Handle(char input);
    }
}