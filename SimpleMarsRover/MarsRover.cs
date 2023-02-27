using SimpleMarsRover.Domain;
using SimpleMarsRover.Domain.Command;
using SimpleMarsRover.Logging;

namespace SimpleMarsRover
{
    public class MarsRover
    {
        public string Execute(string input)
        {
            ILogger logger = new ConsoleLog();
            Rover rover = new Rover();

            //new TestCommandBus.Client().Run();

            CommandBus commandBus = new CommandBus();
            commandBus.Register(new TurnRightCommandHandler(rover, logger));
            commandBus.Register(new TurnLeftCommandHandler(rover, logger));
            commandBus.Register(new MoveForwardCommandHandler(rover, logger));

            for (var i = 0; i < input.Length; i++)
            {
                ICommand command = CommandFactory(input[i]);
                commandBus.Execute(command);
            }

            return rover.Print();
        }

        private ICommand CommandFactory(char input)
        {
            if (input == 'R') return new TurnRightCommand();
            if (input == 'L') return new TurnLeftCommand();

            return new MoveForwardCommand();
        }
    }

}

//namespace TestCommandBus
//{

//    public interface Command { }

//    public class CreateProductCommand : Command { }

//    public interface CommandHandler<TCommand> where TCommand : Command
//    {
//        void Handle(TCommand command);
//    }

//    public class CreateProductCommandHandler : CommandHandler<CreateProductCommand>
//    {
//        public void Handle(CreateProductCommand command)
//        {
//            Console.WriteLine("GetMovesCommand executed");
//        }
//    }

//    public class InMemoryCommandBus
//    {
//        IDictionary<Type, object> handlers = new Dictionary<Type, object>();
//        public void Register<TCommand>(Type type, CommandHandler<TCommand> commandHandler) where TCommand : Command
//        {
//            handlers.Add(type, commandHandler);
//        }

//        public void Execute<TCommand>(TCommand command) where TCommand : Command
//        {
//            ((CommandHandler<TCommand>)handlers[command.GetType()]).Handle(command);
//        }
//    }

//    public class Client
//    {
//        public void Run()
//        {
//            var getMovesCommand = new CreateProductCommand();
//            var getMovesCommandHandler = new CreateProductCommandHandler();
//            var bus = new InMemoryCommandBus();
//            bus.Register(typeof(CreateProductCommand), getMovesCommandHandler);
//            bus.Execute(getMovesCommand);
//        }
//    }
//}