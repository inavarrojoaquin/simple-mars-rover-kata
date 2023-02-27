namespace SimpleMarsRover.Logging
{
    public interface ILogger
    {
        void Clean();
        void Log(string logMsg);
        string ReadAll();
    }
}