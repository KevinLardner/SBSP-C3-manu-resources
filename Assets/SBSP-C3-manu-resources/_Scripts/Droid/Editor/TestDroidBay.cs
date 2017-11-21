using NUnit.Framework;

namespace UnityTest
{
    [TestFixture]
    internal class CheckIfDroidIsEmptyWhenDroidBayIsCreated
    {
        [Test]
        public void TestDroidBayIsEmpty()
        {
            // Arrange
            DroidBayModel db = new DroidBayModel();

            // Act
            Droid expectedResult = null;

            // Assert
            Assert.AreEqual(db.GetDroid(), expectedResult);
        }

        [Test]
        public void TestAddDroidToNull()
        {
            // Arrange
            DroidBayModel db = new DroidBayModel();

            Droid newDroid = new Droid();

            db.SetDroid(newDroid);

            // Act
            Droid expectedResult = newDroid;

            // Assert
            Assert.AreEqual(db.GetDroid(), expectedResult);
        }
    }
}