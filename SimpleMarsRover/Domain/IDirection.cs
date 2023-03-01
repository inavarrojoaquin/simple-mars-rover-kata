namespace SimpleMarsRover.Domain
{
    public interface IDirection
    {
        IDirection TurnRight();
        IDirection TurnLeft();
    }
}