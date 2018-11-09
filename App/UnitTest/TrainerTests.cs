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
            if(trainer.UseMove(1) && trainer.UseMove(0))
            {
                // expected behaviour
            }
            else
            {
                Assert.Fail("Expected a move to be locked in");
            }
        }

        [TestMethod]
        public void TestReady()
        {
            var trainer = new Trainer();
            if (trainer.Ready)
                Assert.Fail("Trainer should not be ready by default.");
            var mockPokemon = new Mock<IPokemon>();
            var list = new List<IMove>
            {
                new Move(),
            };
            mockPokemon.Setup(po => po.Moves).Returns(list);
            trainer.ActivePokemon = mockPokemon.Object;
            trainer.UseMove(4);
            if (trainer.Ready)
                Assert.Fail("Trainer should not be Ready when picking an invalid move");
            trainer.UseMove(0);
            if (false == trainer.Ready)
                Assert.Fail("Trainer should be ready after locking in a move!");
        }

        [TestMethod]
        public void TestTryGetMove()
        {
            IMove move;
            var trainer = new Trainer();
            if (trainer.TryGetMove(out move))
                Assert.Fail("Trainer should not have a move locked in already.");
            var mockPokemon = new Mock<IPokemon>();
            var list = new List<IMove>
            {
                new Move(),
                new Move(),
            };
            var expected = list[0];
            mockPokemon.Setup(po => po.Moves).Returns(list);
            trainer.ActivePokemon = mockPokemon.Object;
            trainer.UseMove(4);
            if (trainer.TryGetMove(out move))
                Assert.Fail("Trainer should not be Ready when picking an invalid move");
            trainer.UseMove(0);
            if(trainer.TryGetMove(out move))
            {
                Assert.AreEqual(move, expected);
                Assert.AreNotEqual(move, list[1]);
            }
            else
            {
                Assert.Fail("A move should be locked in now!");
            }
            trainer.UseMove(1);
            if (trainer.TryGetMove(out move))
            {
                Assert.AreEqual(move, list[1]);
                Assert.AreNotEqual(move, list[0]);
            }
            else
            {
                Assert.Fail("A move should be locked in now!");
            }
        }
    }
}
