namespace SimpleMarsRover.Domain
{
    public class NorthDirection : IDirection
    {
        public IDirection TurnLeft()
        {
            return new WestDirection();
        }

        public IDirection TurnRight()
        {
            return new EastDirection();
        }

        public override string ToString()
        {
            return Directions.N.ToString();
        }
    }
}