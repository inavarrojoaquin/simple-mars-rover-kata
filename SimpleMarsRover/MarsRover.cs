using SimpleMarsRover.Domain;
using SimpleMarsRover.Logging;

namespace SimpleMarsRover
{
    public class MarsRover
    {
        private Rover plateu;

        public string Execute(string input)
        {
            ILogType logType = new ConsoleLog();
            ILogger logger = new Logger(logType);
            plateu = new Rover(logger);
            plateu.Move(input);

            return plateu.Print();
        }
    }
}