namespace SimpleMarsRover.Logging
{
    internal class ConsoleLogShould
    {
        private const string INIT_HELLO_FINISG_MSG = "Init...\nHello World!\nFinish!\n";

        [Test]
        public void LoggingMessageToConsole() {

            ILogType consoleLogType = new ConsoleLog();
            ILogger logger = new Logger(consoleLogType);
            
            Assert.DoesNotThrow(() => logger.Log(INIT_HELLO_FINISG_MSG));
        }

        [Test]
        public void ReadAllFromConsole()
        {
            ILogType fileLogType = new ConsoleLog();
            ILogger logger = new Logger(fileLogType);

            logger.Log(INIT_HELLO_FINISG_MSG);

            var output = logger.ReadAll();

            Assert.That(output.Contains("Init"), Is.True);
            Assert.That(output.Contains("Hello World!"), Is.True);
            Assert.That(output.Contains("Finish"), Is.True);
        }

        [Test]
        public void CleanConsole()
        {
            ILogType fileLogType = new ConsoleLog();
            ILogger logger = new Logger(fileLogType);

            logger.Clean();

            string output = logger.ReadAll();

            Assert.IsTrue(string.IsNullOrEmpty(output));
        }
    }
}
