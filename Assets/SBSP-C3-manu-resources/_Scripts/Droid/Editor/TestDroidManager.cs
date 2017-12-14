using NUnit.Framework;
using UnityEngine;

namespace UnityTest
{
    [TestFixture]
    internal class CheckDroidPropertiesAreNullAtStart
    { 
        /**
         * Checks no droid is present prior to the "Deploy" button being pressed.
         */
        [Test]
        public void TestDroidIsNotDeployedAtStart()
        {
            // Arrange
            DroidBayModel dbm = new DroidBayModel();

            // Assert
            Assert.IsNull(dbm.GetDroid());
        }

        /**
         * Checks no bays are created prior to the "Add Bay" button being pressed.
         */
        [Test]
        public void TestBayIndexStartsAtZero()
        {
            // Arrange
            DroidBayModel dbm = new DroidBayModel();

            // Act
            var expectedResult = 0;

            // Assert
            Assert.AreEqual(dbm.GetBayIndex(), expectedResult);
        }
    }
}