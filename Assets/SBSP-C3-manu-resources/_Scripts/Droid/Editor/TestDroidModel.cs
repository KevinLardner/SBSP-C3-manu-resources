using NUnit.Framework;

namespace UnityTest
{
    [TestFixture]
    internal class CheckIfDroidAttributesEqualsTen
    {
        [Test]
        public void TestDroidHealthIsTen()
        {
            // Arrange
            DroidModel dm = new DroidModel();

            // Act
            DroidModel expectedResult = 10;

            // Assert
            Assert.AreEqual(dm.GetDroid(), expectedResult);
        }

        [Test]
        public void TestDroidEnergyIsTen()
        {
            // Arrange
            DroidModel dm = new DroidModel();

            // Act
            Droid expectedResult = 10;

            // Assert
            Assert.AreEqual(dm.GetEnergy(), expectedResult);
        }

        [Test]
        public void TestDroidDeployTimeIsTen()
        {
            // Arrange
            DroidModel dm = new DroidModel();

            // Act
            Droid expectedResult = 10;

            // Assert
            Assert.AreEqual(dm.GetDeploytime(), expectedResult);
        }
    }
}