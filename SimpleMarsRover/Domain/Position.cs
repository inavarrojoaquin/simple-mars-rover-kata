using System;

namespace SimpleMarsRover.Domain
{
    internal class Position
    {
        int x;
        int y;

        public Position(int positionX, int positionY)
        {
            x = positionX;
            y = positionY;
        }

        internal Position Update(string direction)
        {
            if (direction == Directions.N.ToString()) y += 1;
            if (direction == Directions.E.ToString()) x += 1;
            if (direction == Directions.S.ToString()) y -= 1;
            if (direction == Directions.W.ToString()) x -= 1;

            if (x > 9) x -= 10;
            if (y > 9) y -= 10;

            return new Position(x, y);
        }

        public (int, int) ToPairInt()
        {
            return (x, y);
        }
    }
}