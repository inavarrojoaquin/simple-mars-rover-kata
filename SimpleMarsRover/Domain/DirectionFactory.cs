namespace SimpleMarsRover.Domain
{
    internal class DirectionFactory
    {
        internal static string TurnLeft(string name)
        {
            if (name == "N") { return Directions.W.ToString(); }
            if (name == "W") { return Directions.S.ToString(); }
            if (name == "S") { return Directions.E.ToString(); }

            return Directions.N.ToString();
        }

        internal static string TurnRigth(string name)
        {
            if (name == "N") { return Directions.E.ToString(); }
            if (name == "E") { return Directions.S.ToString(); }
            if (name == "S") { return Directions.W.ToString(); }

            return Directions.N.ToString();
        }
    }
}