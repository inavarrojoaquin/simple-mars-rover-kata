using System;

namespace SimpleMarsRover
{
    internal class Position
    {
        public int X { get; internal set; }
        public int Y { get; internal set; }

        public Position(int positionX, int positionY)
        {
            X = positionX;
            Y = positionY;
        }

        internal Position Update(string direction)
        {
            if (direction == Directions.N.ToString()) Y += 1;
            if (direction == Directions.E.ToString()) X += 1;
            if (direction == Directions.S.ToString()) Y -= 1;
            if (direction == Directions.W.ToString()) X -= 1;

            return new Position(X, Y);
        }
    }
}