﻿namespace SimpleMarsRover
{
    internal class RoverCommandFactory
    {
        internal static IRoverCommand Create(char input, Rover rover)
        {
            if (input == 'R') return new TurnRightCommand(rover);
            if (input == 'L') return new TurnLeftCommand(rover);

            return new MoveForwardCommand(rover);
        }
    }
}