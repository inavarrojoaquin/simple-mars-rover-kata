using SimpleMarsRover.Logging;

namespace SimpleMarsRover.Domain.Command
{
    public class TurnRightCommandHandler : BaseCommandHandler//, ICommandHandler<TurnRightCommand>
    {
        private IRover rover;
        private readonly ILogger logger;

        public TurnRightCommandHandler(IRover rover, ILogger logger)
        {
            this.rover = rover;
            this.logger = logger;
        }

        public override void Handle(char input)
        {
            if(input == 'R')
            {
                rover.TurnRight();
                //logger.Log(string.Format("TurnRight with Guid {0}", command.TurnRightGuid));
                return;
            }

            nextHandler.Handle(input);    
        }
    }
}