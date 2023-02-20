namespace SimpleMarsRover.Domain
{
    public class Direction
    {
        string name;

        public Direction()
        {
            name = Directions.N.ToString();
        }

        public void TurnRight()
        {
            name = DirectionFactory.TurnRigth(name);
        }

        public void TurnLeft()
        {
            name = DirectionFactory.TurnLeft(name);
        }

        public override string ToString()
        {
            return name;
        }
    }

    public enum Directions
    {
        N,
        S,
        E,
        W
    }
}