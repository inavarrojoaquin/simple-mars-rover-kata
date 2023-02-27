using SimpleMarsRover.Logging;

namespace SimpleMarsRover.Domain.Command
{
    public class TurnRightCommandHandler : ICommandHandler<TurnRightCommand>
    {
        private Rover rover;
        private readonly ILogger logger;

        public TurnRightCommandHandler(Rover rover, ILogger logger)
        {
            this.rover = rover;
            this.logger = logger;
        }

        public void Handle(TurnRightCommand command)
        {
            rover.TurnRight();
            logger.Log(string.Format("TurnRight with Guid {0}", command.TurnRightGuid));
        }
    }
}