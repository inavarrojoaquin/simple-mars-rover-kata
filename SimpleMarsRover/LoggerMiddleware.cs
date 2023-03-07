using SimpleMarsRover.Domain.Command;
using SimpleMarsRover.Logging;

namespace SimpleMarsRover
{
    public class LoggerMiddleware<T> : IMiddleware<T> where T : ICommand
    {
        private ILogger logger;
        private readonly IMiddleware<T> middlware;

        public LoggerMiddleware(ILogger logger, IMiddleware<T> middleware)
        {
            this.logger = logger;
            this.middlware = middleware;
        }

        public void Handle(T command)
        {
            logger.Log("LoggerMiddleware: " + command.GetType() + "\n");
            middlware.Handle(command);
        }
    }
}