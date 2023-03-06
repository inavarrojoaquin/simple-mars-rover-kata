using SimpleMarsRover.Domain.Command;
using SimpleMarsRover.Logging;

namespace SimpleMarsRover
{
    public class LoggerMiddleware<T> : IMiddleware<T> where T : ICommand
    {
        private ILogger logger;
        private readonly CommandHandlerMiddleware<T> commandHandlerMiddlware;

        public LoggerMiddleware(ILogger logger, CommandHandlerMiddleware<T> commandHandlerMiddlware)
        {
            this.logger = logger;
            this.commandHandlerMiddlware = commandHandlerMiddlware;
        }

        public void Handle(T command)
        {
            logger.Log("LoggerMiddleware: " + command.GetType() + "\n");
            commandHandlerMiddlware.Handle(command);
        }
    }
}