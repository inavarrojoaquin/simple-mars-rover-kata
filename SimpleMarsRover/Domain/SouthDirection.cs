namespace SimpleMarsRover.Domain
{
    public class SouthDirection : IDirection
    {
        public IDirection TurnLeft()
        {
            return new EastDirection();
        }

        public IDirection TurnRight()
        {
            return new WestDirection();
        }
        public override string ToString()
        {
            return Directions.S.ToString();
        }
    }
}