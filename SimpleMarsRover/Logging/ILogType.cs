namespace SimpleMarsRover.Logging
{
    internal interface ILogType
    {
        void Log(string logMsg);
        string ReadAll();
        void Clean();
    }
}