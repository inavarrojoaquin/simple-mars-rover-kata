using SimpleMarsRover.Logging;

namespace SimpleMarsRover.Test.Logging
{
    internal class ConsoleLogShould
    {
        private const string INIT_HELLO_FINISG_MSG = "Init...\nHello World!\nFinish!\n";
        private ConsoleLog logger;

        [SetUp]
        public void SetUp() 
        {
            logger = new ConsoleLog();
        }

        [Test]
        public void LoggingMessageToConsole()
        {
            Assert.DoesNotThrow(() => logger.Log(INIT_HELLO_FINISG_MSG));
        }

        [Test]
        public void ReadAllFromConsole()
        {
            logger.Log(INIT_HELLO_FINISG_MSG);

            var output = logger.ReadAll();

            Assert.That(output.Contains("Init"), Is.True);
            Assert.That(output.Contains("Hello World!"), Is.True);
            Assert.That(output.Contains("Finish"), Is.True);
        }

        [Test]
        public void CleanConsole()
        {
            logger.Clean();

            string output = logger.ReadAll();

            Assert.IsTrue(string.IsNullOrEmpty(output));
        }
    }
}
