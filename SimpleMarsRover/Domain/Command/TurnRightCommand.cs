namespace SimpleMarsRover.Domain.Command
{
    internal class TurnRightCommand : IRoverCommand
    {
        private Rover rover;

        public TurnRightCommand(Rover rover)
        {
            this.rover = rover;
        }

        public void Execute()
        {
            rover.TurnRight();
        }
    }
}