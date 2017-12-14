using NUnit.Framework;
using UnityEngine;

namespace UnityTest
{
    [TestFixture]
    internal class CheckSearchDroidValuesAreSetCorrectly
    {
        /**
         * Checks max health value is 100
         */
        [Test]
        public void TestSearchDroidMaxHealthIsOneHundred()
        {
            // Arrange
            SearchDroidModel sdm = new SearchDroidModel();

            // Act
            var result = 100;

            // Assert
            Assert.AreEqual(sdm.GetDroidMaxHealth(), result);
        }

        /**
         * Checks energy consumption value is 3
         */
        [Test]
        public void TestSearchDroidEnergyConsumptionIsThree()
        {
            // Arrange
            SearchDroidModel sdm = new SearchDroidModel();

            var result = 3;

            // Assert
            Assert.AreEqual(sdm.GetEnergyConsumption(), result);
        }

        /**
         * Checks max energy value is 200
         */
        [Test]
        public void TestSearchDroidMaxEnergyIsTwoHundred()
        {
            // Arrange
            SearchDroidModel sdm = new SearchDroidModel();

            var result = 200;

            // Assert
            Assert.AreEqual(sdm.GetDroidMaxEnergy(), result);
        }

        [Test]
        public void TestSearchDroidStorageCapacityIsTen()
        {
            // Arrange
            SearchDroidModel sdm = new SearchDroidModel();

            var result = 10;

            // Assert
            Assert.AreEqual(sdm.GetDroidStorageCapacity(), result);
        }
    }
}