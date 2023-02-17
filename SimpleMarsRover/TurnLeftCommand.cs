using System.Windows.Input;

namespace SimpleMarsRover
{
    internal class TurnLeftCommand : IRoverCommand
    {
        private Rover rover;

        public TurnLeftCommand(Rover rover)
        {
            this.rover = rover;
        }

        public void Execute()
        {
            rover.TurnLeft();
        }
    }
}