namespace SimpleMarsRover.Domain
{
    public class WestDirection : IDirection
    {
        public IDirection TurnLeft()
        {
            return new SouthDirection();
        }

        public IDirection TurnRight()
        {
            return new NorthDirection();
        }

        public override string ToString()
        {
            return Directions.W.ToString();
        }
    }
}