using System;

namespace SimpleMarsRover
{
    public class MarsRover
    {
        private Rover plateu;

        public string Execute(string input)
        {
            plateu = new Rover();
            plateu.Move(input);

            return plateu.Print();
        }
    }
}