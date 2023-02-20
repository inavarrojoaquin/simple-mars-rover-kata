using SimpleMarsRover.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarsRover.Test.Domain
{
    internal class DirectionShould
    {
        #region Turning Right
        [Test]
        public void PlacedInEastWhenTurningRightFromNorth()
        {
            Direction direction = new Direction();
            direction.TurnRight();
            
            Assert.That(direction.ToString(), Is.EqualTo("E"));
        }

        [Test]
        public void PlacedInSouthWhenTurningRightFromEast()
        {
            Direction direction = new Direction();
            direction.TurnRight();
            direction.TurnRight();

            Assert.That(direction.ToString(), Is.EqualTo("S"));
        }

        [Test]
        public void PlacedInWestWhenTurningRightFromSouth()
        {
            Direction direction = new Direction();
            direction.TurnRight();
            direction.TurnRight();
            direction.TurnRight();

            Assert.That(direction.ToString(), Is.EqualTo("W"));
        }

        [Test]
        public void PlacedInNorthWhenTurningRightFromWest()
        {
            Direction direction = new Direction();
            direction.TurnRight();
            direction.TurnRight();
            direction.TurnRight();
            direction.TurnRight();

            Assert.That(direction.ToString(), Is.EqualTo("N"));
        }
        #endregion

        #region Turning Left
        
        [Test]
        public void PlacedInWestWhenTurningRightFromNorth()
        {
            Direction direction = new Direction();
            direction.TurnLeft();

            Assert.That(direction.ToString(), Is.EqualTo("W"));
        }

        [Test]
        public void PlacedInSouthWhenTurningRightFromWest()
        {
            Direction direction = new Direction();
            direction.TurnLeft();
            direction.TurnLeft();

            Assert.That(direction.ToString(), Is.EqualTo("S"));
        }

        [Test]
        public void PlacedInEastWhenTurningRightFromSouth()
        {
            Direction direction = new Direction();
            direction.TurnLeft();
            direction.TurnLeft();
            direction.TurnLeft();

            Assert.That(direction.ToString(), Is.EqualTo("E"));
        }

        [Test]
        public void PlacedInNorthWhenTurningRightFromEast()
        {
            Direction direction = new Direction();
            direction.TurnLeft();
            direction.TurnLeft();
            direction.TurnLeft();
            direction.TurnLeft();

            Assert.That(direction.ToString(), Is.EqualTo("N"));
        }
        #endregion
    }
}
