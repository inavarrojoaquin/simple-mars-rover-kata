using SimpleMarsRover.Domain;
using SimpleMarsRover.Logging;

namespace SimpleMarsRover
{
    public class MarsRover
    {
        public string Execute(string input)
        {
            ILogger logger = new ConsoleLog();
            Rover plateu = new Rover(logger);
            plateu.Move(input);

            return plateu.Print();
        }
    }
}