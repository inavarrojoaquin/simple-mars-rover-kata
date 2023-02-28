namespace SimpleMarsRover
{
    public class LunarRover : ILunarRover
    {
        private int xPos;
        private int yPos;

        public LunarRover(int xPos, int yPos)
        {
            this.xPos = xPos;
            this.yPos = yPos;
        }

        public void moveLeft()
        {
            xPos--;
        }

        public void moveRight()
        {
            xPos++;
        }

        public void moveUp()
        {
            yPos++;
        }

        public void moveDown()
        {
            yPos--;
        }

        public override string ToString()
        {
            return xPos + " " + yPos;
        }
        
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null || this.GetType() != obj.GetType()) return false;
            LunarRover that = (LunarRover)obj;
            return xPos == that.xPos &&
                    yPos == that.yPos;
        }

        public override int GetHashCode()
        {
            return System.HashCode.Combine(xPos, yPos);
        }
    }
}