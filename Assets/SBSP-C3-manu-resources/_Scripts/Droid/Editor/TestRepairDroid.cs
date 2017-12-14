using NUnit.Framework;
using UnityEngine;

namespace UnityTest
{
    [TestFixture]
    internal class CheckRepairDroidValuesAreSetCorrectly
    {
        /**
         * Checks max health value is 10
         */
        [Test]
        public void TestRepairDroidMaxHealthIsOneHundredAndFifty()
        {
            // Arrange
            RepairDroidModel rdm = new RepairDroidModel();

            // Act
            var result = 150;

            // Assert
            Assert.AreEqual(rdm.GetDroidMaxHealth(), result);
        }

        /**
         * Checks max energy value is 10
         */
        [Test]
        public void TestRepairDroidMaxEnergyIsOneHundred()
        {
            // Arrange
            RepairDroidModel rdm = new RepairDroidModel();

            var result = 100;

            // Assert
            Assert.AreEqual(rdm.GetDroidMaxEnergy(), result);
        }
        
        /**
         * Checks deploy time is 25
         */
        [Test]
        public void TestRepairDroidDeployTime()
        {
            // Arrange
            RepairDroidModel rdm = new RepairDroidModel();

            var result = 25;

            // Assert
            Assert.AreEqual(rdm.GetDroidDeployTime(), result);
        }
    }
}