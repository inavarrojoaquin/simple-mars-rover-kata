namespace SimpleMarsRover.Domain
{
    public class EastDirection : IDirection
    {
        public IDirection TurnLeft()
        {
            return new NorthDirection();
        }

        public IDirection TurnRight()
        {
            return new SouthDirection();
        }
        public override string ToString()
        {
            return Directions.E.ToString();
        }
    }
}