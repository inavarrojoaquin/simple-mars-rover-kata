namespace SimpleMarsRover.Logging
{
    internal class ConsoleLog : ILogger
    {
        private StringWriter stringWriter;

        public ConsoleLog()
        {
            stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            Console.SetError(stringWriter);
        }
        public void Log(string logMsg)
        {
            Console.WriteLine(logMsg);
        }

        public string ReadAll()
        {
            return stringWriter.ToString(); 
        }

        public void Clean()
        {
            stringWriter.Flush();
        }
    }
}