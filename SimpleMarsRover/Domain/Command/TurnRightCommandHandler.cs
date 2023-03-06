using SimpleMarsRover.Logging;

namespace SimpleMarsRover.Domain.Command
{
    public class TurnRightCommandHandler : ICommandHandler<TurnRightCommand>
    {
        private IRover rover;
        private readonly ILogger logger;

        public TurnRightCommandHandler(IRover rover, ILogger logger)
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