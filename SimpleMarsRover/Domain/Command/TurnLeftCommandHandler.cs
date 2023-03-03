using SimpleMarsRover.Logging;

namespace SimpleMarsRover.Domain.Command
{
    internal class TurnLeftCommandHandler : BaseCommandHandler // ICommandHandlerT<TurnLeftCommand>
    {
        private IRover rover;
        private readonly ILogger logger;

        public TurnLeftCommandHandler(IRover rover, ILogger logger)
        {
            this.rover = rover;
            this.logger = logger;
        }


        public override void Handle(char input)
        {
            if (input == 'L')
            {
                rover.TurnLeft();
                //logger.Log(string.Format("TurnLeft with Guid {0}", command.TurnLeftGuid));
                return;
            }

            nextHandler.Handle(input);
        }
    }
}