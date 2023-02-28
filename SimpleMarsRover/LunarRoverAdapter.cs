using SimpleMarsRover.Domain;

namespace SimpleMarsRover
{
    public class LunarRoverAdapter : IRover
    {
        private ILunarRover lunarRover;
        private Direction direction;

        public LunarRoverAdapter(ILunarRover lunarRover)
        {
            this.lunarRover = lunarRover;
            direction = new Direction();
        }

        public void MoveForward()
        {
            if (direction.ToString() == Directions.N.ToString())
                MoveY();

            if (direction.ToString() == Directions.S.ToString())
                lunarRover.moveDown();

            if (direction.ToString() == Directions.E.ToString())
                MoveX();
                
            if (direction.ToString() == Directions.W.ToString())
                lunarRover.moveLeft();
        }

        public void TurnLeft()
        {
            direction.TurnLeft();
        }

        public void TurnRight()
        {
            direction.TurnRight();
        }
        
        public string Print()
        {
            char[] xy = XYToCharArray();

            return xy[0] + ":" + xy[1] + ":" + direction.ToString();
        }

        private int GetX()
        {
            return int.Parse(XYToCharArray()[0].ToString());
        }
        private int GetY()
        {
            return int.Parse(XYToCharArray()[1].ToString());
        }

        private char[] XYToCharArray()
        {
            return lunarRover.ToString().Replace(" ", "").ToCharArray();
        }

        private void MoveY()
        {
            if (GetY() == 9)
            {
                MoveYToPosition0();
                return;
            }
            lunarRover.moveUp();
        }

        private void MoveX()
        {
            if (GetX() == 9)
            {
                MoveXToPosition0();
                return;
            }
            lunarRover.moveRight();
        }
        private void MoveXToPosition0()
        {
            do lunarRover.moveLeft();
            while (GetX() > 0);
        }
        private void MoveYToPosition0()
        {
            do lunarRover.moveDown();
            while (GetY() > 0);
        }
    }
}