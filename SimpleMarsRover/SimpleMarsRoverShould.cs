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

        #region Movement (M) to the North (N)
        [TestCase("M", "0:1:N")]
        [TestCase("MM", "0:2:N")]
        [TestCase("MMM", "0:3:N")]
        [TestCase("MMMM", "0:4:N")]
        public void MoveOnePositionToNorthFromStartingPosition(string input, string expected)
        {
            string result = new MarsRover().Execute(input);
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region Movement (M) to the North (S)
        
        #endregion
    }
}