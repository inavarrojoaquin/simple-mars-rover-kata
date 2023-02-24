using SimpleMarsRover.Logging;

namespace SimpleMarsRover.Test.Logging
{
    internal class FileLogShould
    {
        private const string INIT_HELLO_FINISG_MSG = "Init...\nHello World!\nFinish!\n";
        private FileLog logger;

        [SetUp]
        public void SetUp()
        {
            logger = new FileLog(@"C:\tmp\rover_log.txt");
        }

        [Test]
        public void LogginMessagesToFile()
        {
            Assert.DoesNotThrow(() => logger.Log(INIT_HELLO_FINISG_MSG));
        }

        [Test]
        public void ReadAllFromFile()
        {
            logger.Log(INIT_HELLO_FINISG_MSG);

            var output = logger.ReadAll();

            Assert.That(output.Contains("Init"), Is.True);
            Assert.That(output.Contains("Hello World!"), Is.True);
            Assert.That(output.Contains("Finish"), Is.True);
        }

        [Test]
        public void CleanFile()
        {
            logger.Clean();

            string output = logger.ReadAll();

            Assert.IsTrue(string.IsNullOrEmpty(output));
        }

        [Test]
        public void GetEmptyStringIfFileDoesNotExists()
        {
            logger.Clean();

            string output = logger.ReadAll();

            Assert.IsTrue(string.IsNullOrEmpty(output));
        }
    }
}