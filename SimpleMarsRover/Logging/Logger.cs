namespace SimpleMarsRover.Logging
{
    internal class Logger : ILogger
    {
        private ILogType logType;

        public Logger(ILogType logType)
        {
            this.logType = logType;
        }

        public void Log(string msg)
        {
            logType.Log(msg);
        }

        public string ReadAll()
        {
            return logType.ReadAll();
        }

        public void Clean()
        {
            logType.Clean();
        }
    }
}