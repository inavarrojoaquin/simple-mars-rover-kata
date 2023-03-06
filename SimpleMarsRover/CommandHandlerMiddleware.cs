using SimpleMarsRover.Domain.Command;

namespace SimpleMarsRover
{
    public class CommandHandlerMiddleware<T> : IMiddleware<T> where T : ICommand
    {
        private ICommandHandler<T> commandHandler;

        public CommandHandlerMiddleware(ICommandHandler<T> commandHandler)
        {
            this.commandHandler = commandHandler;
        }

        public void Handle(T command)
        {
            commandHandler.Handle(command);
        }
    }
}