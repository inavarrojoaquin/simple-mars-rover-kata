namespace SimpleMarsRover.Logging
{
    internal class FileLogShould
    {
        private const string INIT_HELLO_FINISG_MSG = "Init...\nHello World!\nFinish!\n";

        [Test]
        public void LogginMessagesToFile()
        {
            ILogType fileLogType = new FileLog(@"C:\tmp\rover_log.txt");
            ILogger logger = new Logger(fileLogType);

            Assert.DoesNotThrow(() => logger.Log(INIT_HELLO_FINISG_MSG));
        }

        [Test]
        public void ReadAllFromFile() {

            ILogType fileLogType = new FileLog(@"C:\tmp\rover_log.txt");
            ILogger logger = new Logger(fileLogType);
            
            logger.Log(INIT_HELLO_FINISG_MSG);

            var output = logger.ReadAll();

            Assert.That(output.Contains("Init"), Is.True);
            Assert.That(output.Contains("Hello World!"), Is.True);
            Assert.That(output.Contains("Finish"), Is.True);
        }

        [Test]  
        public void CleanFile()
        {
            ILogType fileLogType = new FileLog(@"C:\tmp\rover_log.txt");
            ILogger logger = new Logger(fileLogType);

            logger.Clean();

            string output = logger.ReadAll();
            
            Assert.IsTrue(string.IsNullOrEmpty(output));
        }

        [Test]
        public void GetEmptyStringIfFileDoesNotExists()
        {
            ILogType fileLogType = new FileLog(@"C:\tmp\rover_log.txt");
            ILogger logger = new Logger(fileLogType);

            logger.Clean();

            string output = logger.ReadAll();

            Assert.IsTrue(string.IsNullOrEmpty(output));
        }
    }
}
