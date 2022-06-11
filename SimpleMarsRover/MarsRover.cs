using System;

namespace SimpleMarsRover
{
    public class MarsRover
    {
        private Plateu plateu;

        public string Execute(string input)
        {
            plateu = new Plateu();
            plateu.Move(input);

            return plateu.Print();
        }
    }
}