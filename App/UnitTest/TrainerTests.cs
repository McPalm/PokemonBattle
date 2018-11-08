using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Model;

namespace UnitTest
{
    [TestClass]
    public class TrainerTests
    {
        [TestMethod]
        public void TestNewTrainer()
        {
            var trainer = new Trainer("Ash");
            var expected = "Ash";
            var actual = trainer.Name;
            Assert.AreEqual(expected, actual);
        }
    }
}
