using NUnit.Framework;
using UnityEngine;

namespace UnityTest
{
    [TestFixture]
    internal class CheckDroidValuesAreInitiallySetToNull
    {
        /**
         * Checks max health value is 10
         */
        [Test]
        public void TestDroidMaxHealthIsTen()
        {
            // Arrange
            DroidModel dm = new DroidModel();

            // Act
            var result = 10;

            // Assert
            Assert.AreEqual(dm.GetDroidMaxHealth(), result);
        }

        /**
         * Checks max energy value is 10
         */
        [Test]
        public void TestDroidMaxEnergyIsTen()
        {
            // Arrange
            DroidModel dm = new DroidModel();

            // Act
            var result = 10;

            // Assert
            Assert.AreEqual(dm.GetDroidMaxEnergy(), result);
        }

        /**
         * Checks current energy level is zero at start of game
         */
        [Test]
        public void TestDroidCurrentEnergyIsZero()
        {
            // Arrange
            DroidModel dm = new DroidModel();

            // Act
            var result = 0;

            // Assert
            Assert.AreEqual(dm.GetDroidCurrentEnergy(), result);
        }

        /**
         * Checks current health level is zero at start of game
         */
        [Test]
        public void TestDroidCurrentHealthIsZero()
        {
            // Arrange
            DroidModel dm = new DroidModel();

            // Act
            var result = 0;

            // Assert
            Assert.AreEqual(dm.GetDroidCurrentHealth(), result);
        }

        /**
         * Checks droid deploy time is set to 10
         */
        [Test]
        public void TestDroidDeployTimeIs10()
        {
            // Arrange
            DroidModel dm = new DroidModel();

            // Act
            var result = 10;

            // Assert
            Assert.AreEqual(dm.GetDroidDeployTime(), result);
        }
    }
}