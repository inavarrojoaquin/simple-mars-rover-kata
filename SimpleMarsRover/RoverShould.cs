using SimpleMarsRover.Logging;

namespace SimpleMarsRover
{
    internal class RoverShould
    {
        #region Print msg when turning right
        [Test]
        public void PrintMsgWhenTurningRight()
        {
            ILogType logType = new ConsoleLog();
            ILogger logger = new Logger(logType);
            new Rover(logger).Move("R");

            Assert.That(logger.ReadAll().Contains("Turned Right"), Is.True);
        }
        #endregion

        #region Print msg when turning left
        [Test]
        public void PrintMsgWhenTurningLeft()
        {
            ILogType logType = new ConsoleLog();
            ILogger logger = new Logger(logType);
            new Rover(logger).Move("L");

            Assert.That(logger.ReadAll().Contains("Turned Left"), Is.True);
        }
        #endregion

        #region Print msg when moving forward
        [Test]
        public void PrintMsgWhenMovingForward()
        {
            ILogType logType = new ConsoleLog();
            ILogger logger = new Logger(logType);
            new Rover(logger).Move("M");

            Assert.That(logger.ReadAll().Contains("Moved Forward"), Is.True);
        }
        #endregion
    }
}
