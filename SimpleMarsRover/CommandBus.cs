using SimpleMarsRover.Domain.Command;

namespace SimpleMarsRover
{
    public class CommandBus
    {
        private IDictionary<string, object> handlers;

        public CommandBus()
        {
            //handlers = new Dictionary<Type, object>();
            handlers = new Dictionary<string, object>();
        }

        internal void Execute(string position, char input)
        {
            ((BaseCommandHandler)handlers[position]).Handle(input);
            // cadena de acciones
            // 1 - Log init
            // 2 - Command execute
            // 3 - Log finish
            
        }

        internal void Register(string position, BaseCommandHandler commandHandler)
        {
            handlers.Add(position, commandHandler);
        }
        //internal void Execute<T>(T command) where T: ICommand
        //{
        //    // cadena de acciones
        //    // 1 - Log init
        //    // 2 - Command execute
        //    // 3 - Log finish
        //    ((ICommandHandler<T>)handlers[command.GetType()]).Handle(command);
        //}

        //internal void Register<T>(ICommandHandler<T> commandHandler) where T : ICommand
        //{
        //    handlers.Add(typeof(T), commandHandler);
        //}
    }
}