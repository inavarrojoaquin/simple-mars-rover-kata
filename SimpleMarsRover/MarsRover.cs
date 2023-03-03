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
            IRover rover = new Rover();

            ILunarRover lunarRover = new LunarRover(0,0);
            //LunarRoverAdapter rover = new LunarRoverAdapter(lunarRover);

            var firstHandler = new TurnRightCommandHandler(rover, logger);
            var secondHandler = new TurnLeftCommandHandler(rover, logger);
            var thirdHandler = new MoveForwardCommandHandler(rover, logger);
            
            firstHandler.SetNextHandler(secondHandler);
            secondHandler.SetNextHandler(thirdHandler);

            CommandBus commandBus = new CommandBus();
            commandBus.Register("first", firstHandler);

            for (var i = 0; i < input.Length; i++)
                commandBus.Execute("first", input[i]);
                //CommandFactory(input[i], commandBus);

            return rover.Print();
        }

        //private void CommandFactory(char input, CommandBus commandBus)
        //{
        //    if (input == 'R') commandBus.Execute(new TurnRightCommand());
        //    if (input == 'L') commandBus.Execute(new TurnLeftCommand());
        //    if (input == 'M') commandBus.Execute(new MoveForwardCommand());
        //}
    }
}