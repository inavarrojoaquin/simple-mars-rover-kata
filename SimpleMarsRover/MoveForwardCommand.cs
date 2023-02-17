namespace SimpleMarsRover
{
    internal class MoveForwardCommand : IRoverCommand
    {
        private Rover rover;

        public MoveForwardCommand(Rover rover)
        {
            this.rover = rover;
        }

        public void Execute()
        {
            rover.MoveForward();
        }
    }
}