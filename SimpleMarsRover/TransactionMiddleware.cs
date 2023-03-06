using SimpleMarsRover.Domain.Command;
using SimpleMarsRover.Logging;

namespace SimpleMarsRover
{
    public class TransactionMiddleware<T> : IMiddleware<T> where T : ICommand
    {
        private ILogger logger;
        private readonly IMiddleware<T> loggerMiddleware;

        public TransactionMiddleware(ILogger logger, IMiddleware<T> loggerMiddleware)
        {
            this.logger = logger;
            this.loggerMiddleware = loggerMiddleware;
        }

        public void Handle(T command)
        {
            logger.Log("Init TransactionMiddleware: " + command.GetType() + "\n");
            loggerMiddleware.Handle(command);
            logger.Log("Close TransactionMiddleware: " + command.GetType() + "\n");
        }
    }
}