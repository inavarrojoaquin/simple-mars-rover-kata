namespace SimpleMarsRover
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
            if (name == "N") { name = Directions.E.ToString(); return; }
            if (name == "E") { name = Directions.S.ToString(); return; }
            if (name == "S") { name = Directions.W.ToString(); return; }
            if (name == "W") { name = Directions.N.ToString(); return; }
        }

        public void TurnLeft()
        {
            if (name == "N") { name = Directions.W.ToString(); return; }
            if (name == "W") { name = Directions.S.ToString(); return; }
            if (name == "S") { name = Directions.E.ToString(); return; }
            if (name == "E") { name = Directions.N.ToString(); return; }
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