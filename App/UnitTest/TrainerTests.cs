using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Model;
using System.Collections.Generic;
using Moq;

namespace UnitTest
{
    [TestClass]
    public class TrainerTests
    {
        [TestMethod]
        public void TestNewTrainer()
        {
            var trainer = new Trainer()
            {
                Name = "Ash",
            };
            var expected = "Ash";
            var actual = trainer.Name;
            Assert.AreEqual(expected, actual);
        }

        
        [TestMethod]
        public void TestUseMove()
        {
            var trainer = new Trainer();
            var mockPokemon = new Mock<IPokemon>();
            var list = new List<IMove>
            {
                new Move(),
                new Move(),
            };
            mockPokemon.Setup(po => po.Moves).Returns(list);
            trainer.ActivePokemon = mockPokemon.Object;
            if(trainer.UseMove(1))
            {
                // expected behaviour
            }
            else
            {
                Assert.Fail("Expected a move to be locked in");
            }
        }
        
    }
}
