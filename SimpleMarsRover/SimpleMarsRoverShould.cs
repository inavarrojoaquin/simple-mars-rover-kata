using NUnit.Framework;

namespace SimpleMarsRover
{
    public class SimpleMarsRoverShould
    {
        [SetUp]
        public void Setup()
        {
        }

        #region The starting position 0:0:N
        [Test]
        public void StartAtCeroCeroNorth()
        {
            Assert.AreEqual("0:0:N", new MarsRover().Execute(""));
        }
        #endregion

        #region Movement (M) from start position so final Direction keeps North
        [TestCase("M", "0:1:N")]
        [TestCase("MM", "0:2:N")]
        [TestCase("MMM", "0:3:N")]
        [TestCase("MMMM", "0:4:N")]
        public void MoveOnePositionToNorthFromStartingPosition(string input, string expected)
        {
            Assert.AreEqual(expected, new MarsRover().Execute(input));
        }
        #endregion

        #region -> Turns direction to Right (R) from start position
        [TestCase("R", "0:0:E")]
        [TestCase("RR", "0:0:S")]
        [TestCase("RRR", "0:0:W")]
        [TestCase("RRRR", "0:0:N")]
        public void TurnDirectionToRightFromStartingPosition(string input, string expected)
        {
            Assert.AreEqual(expected, new MarsRover().Execute(input));
        }
        #endregion
    }
}