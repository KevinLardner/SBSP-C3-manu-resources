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
    }
}