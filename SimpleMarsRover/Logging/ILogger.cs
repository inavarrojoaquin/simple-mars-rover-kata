namespace SimpleMarsRover.Logging
{
    internal interface ILogger
    {
        void Clean();
        void Log(string logMsg);
        string ReadAll();
    }
}