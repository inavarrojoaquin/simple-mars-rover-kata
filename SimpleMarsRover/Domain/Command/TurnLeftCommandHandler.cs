using SimpleMarsRover.Logging;

namespace SimpleMarsRover.Domain.Command
{
    internal class TurnLeftCommandHandler : ICommandHandler<TurnLeftCommand>
    {
        private IRover rover;
        private readonly ILogger logger;

        public TurnLeftCommandHandler(IRover rover, ILogger logger)
        {
            this.rover = rover;
            this.logger = logger;
        }

        public void Handle(TurnLeftCommand command)
        {
            rover.TurnLeft();
            logger.Log(string.Format("TurnLeft with Guid {0}", command.TurnLeftGuid));
        }
    }
}