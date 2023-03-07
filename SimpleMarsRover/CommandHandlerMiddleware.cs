using SimpleMarsRover.Domain.Command;

namespace SimpleMarsRover
{
    public class CommandHandlerMiddleware<T> : IMiddleware<T> where T : ICommand
    {
        private ICommandHandler<T> commandHandler;
        private readonly IMiddleware<T> nextMiddleware;

        public CommandHandlerMiddleware(ICommandHandler<T> commandHandler, IMiddleware<T> nextMiddleware)
        {
            this.commandHandler = commandHandler;
            this.nextMiddleware = nextMiddleware;
        }

        public void Handle(T command)
        {
            commandHandler.Handle(command);
            
            if(nextMiddleware != null)
                nextMiddleware.Handle(command);
        }
    }
}