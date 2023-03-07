using SimpleMarsRover.Domain.Command;
using SimpleMarsRover.Logging;

namespace SimpleMarsRover
{
    public class CommandBus
    {
        private readonly ILogger logger;
        private IDictionary<Type, object> handlers;

        public CommandBus(ILogger logger)
        {
            handlers = new Dictionary<Type, object>();
            this.logger = logger;
        }
        internal void Execute<T>(T command) where T: ICommand
        {
            ICommandHandler<T> commandHandler = (ICommandHandler<T>)handlers[command.GetType()];
            IMiddleware<T> commandHandlerMiddlware = new CommandHandlerMiddleware<T>(commandHandler, null);
            IMiddleware<T> loggerMiddleware = new LoggerMiddleware<T>(logger, commandHandlerMiddlware);
            IMiddleware<T> transactionMiddleware = new TransactionMiddleware<T>(logger, loggerMiddleware);
            transactionMiddleware.Handle(command);
        }

        internal void Register<T>(ICommandHandler<T> commandHandler) where T : ICommand
        {
            handlers.Add(typeof(T), commandHandler);
        }
    }
}