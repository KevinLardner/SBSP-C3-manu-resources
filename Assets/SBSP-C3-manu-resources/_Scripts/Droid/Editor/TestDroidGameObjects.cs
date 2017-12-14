using NUnit.Framework;
using UnityEngine;

namespace UnityTest
{
    [TestFixture]
    internal class CheckDroidGameObjectsNamesAreCorrect
    {
        [Test]
        public void TestCheckNamesOfGameObjects()
        {
            // Arrange
            var gameTxt = new GameObject("maxBayText");
            var gameBut = new GameObject("createBayButton");
            var gameObj = new GameObject("bayPrefab");

            // Assert
            Assert.AreEqual("maxBayText", gameTxt.name);
            Assert.AreEqual("createBayButton", gameBut.name);
            Assert.AreEqual("bayPrefab", gameObj.name);
        }
    }
}