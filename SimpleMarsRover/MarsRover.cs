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

            CommandBus commandBus = new CommandBus();
            commandBus.Register(new TurnRightCommandHandler(rover, logger));
            commandBus.Register(new TurnLeftCommandHandler(rover, logger));
            commandBus.Register(new MoveForwardCommandHandler(rover, logger));

            for (var i = 0; i < input.Length; i++)
                CommandFactory(input[i], commandBus);

            return rover.Print();
        }

        private void CommandFactory(char input, CommandBus commandBus)
        {
            if (input == 'R') commandBus.Execute(new TurnRightCommand());
            if (input == 'L') commandBus.Execute(new TurnLeftCommand());
            if (input == 'M') commandBus.Execute(new MoveForwardCommand());
        }
    }
}