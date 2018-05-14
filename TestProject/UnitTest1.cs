using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HighScore;
using System.Linq;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        HighScoreController ctrl;
        [TestInitialize]
        public void TestInitialize()
        {
            ctrl = new HighScoreController();
        }
        [TestMethod]
        public void CreateUser_NonExistent()
        {
            Assert.IsFalse(ctrl.GetUsers().Any(u => u.Name == "Tester"));
            var user = ctrl.CreateUser("Tester");
            Assert.IsTrue(ctrl.GetUsers().Any(u => u.Name == "Tester"));
            Assert.AreEqual(user.ID, ctrl.GetUsers().First(u => u.Name == "Tester").ID);
        }
    }
}
