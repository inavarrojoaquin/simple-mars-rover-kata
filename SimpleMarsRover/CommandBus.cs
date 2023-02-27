using SimpleMarsRover.Domain.Command;

namespace SimpleMarsRover
{
    public class CommandBus
    {
        private IDictionary<Type, object> handlers;

        public CommandBus()
        {
            handlers = new Dictionary<Type, object>();
        }
        internal void Execute<T>(T command) where T: ICommand
        {
            var commandHandlerFromDictionary = handlers[command.GetType()];
            ((ICommandHandler<T>)commandHandlerFromDictionary).Handle(command);
            //commandHandler.Handle(command);
        }

        internal void Register<T>(ICommandHandler<T> commandHandler) where T : ICommand
        {
            handlers.Add(typeof(T), commandHandler);
        }
    }
}