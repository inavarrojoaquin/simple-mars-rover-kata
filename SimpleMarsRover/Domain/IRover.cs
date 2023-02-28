namespace SimpleMarsRover.Domain
{
    public interface IRover
    {
        void MoveForward();
        void TurnRight();
        void TurnLeft();
        string Print();
    }
}