using NUnit.Framework;
using UnityEngine;

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
        public void TestDroidIsEmptyWhenAdded()
        {
            // Arrange
            DroidBayModel dbm = new DroidBayModel();

            Droid result = null;

            // Assert
            Assert.AreEqual(dbm.GetDroid(), result);
        }
    }
}