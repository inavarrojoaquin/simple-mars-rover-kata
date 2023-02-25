using SimpleMarsRover.Logging;

namespace SimpleMarsRover.Domain.Command
{
    internal class MoveForwardCommandHandler : ICommandHandler<MoveForwardCommand>
    {
        private Rover rover;
        private readonly ILogger logger;

        public MoveForwardCommandHandler(Rover rover, ILogger logger)
        {
            this.rover = rover;
            this.logger = logger;
        }

        public void Handle(MoveForwardCommand command)
        {
            rover.MoveForward();
            logger.Log(string.Format("MoveForward with Guid {0}", command.MoveForwardGuid));
        }
    }
}