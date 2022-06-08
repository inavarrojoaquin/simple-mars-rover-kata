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
        [Test]
        public void MoveOnePositionToNorth()
        {
            Assert.AreEqual("0:1:N", new MarsRover().Execute("M"));
        }

        [Test]
        public void MoveTwoPositionsToNorth()
        {
            Assert.AreEqual("0:2:N", new MarsRover().Execute("MM"));
        }

        [Test]
        public void MoveThreePositionsToNorth()
        {
            Assert.AreEqual("0:3:N", new MarsRover().Execute("MMM"));
        }

        #endregion
    }
}