using SimpleMarsRover.Logging;

namespace SimpleMarsRover.Domain.Command
{
    internal class MoveForwardCommandHandler : BaseCommandHandler // ICommandHandlerT<MoveForwardCommand>
    {
        private IRover rover;
        private readonly ILogger logger;

        public MoveForwardCommandHandler(IRover rover, ILogger logger)
        {
            this.rover = rover;
            this.logger = logger;
        }

        public override void Handle(char input)
        {
            if (input == 'M')
            {
                rover.MoveForward();
                //logger.Log(string.Format("MoveForward with Guid {0}", command.MoveForwardGuid));
                return;
            }

            nextHandler.Handle(input);
        }
    }
}