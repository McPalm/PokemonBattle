using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Model;
using System.Collections.Generic;

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

        [TestMethod]
        public void TestUseMove()
        {
            var trainer = new Trainer("Ash");
            var pokemon = new MockPokemon("Bulbasaur");
            var move = new MockMove();
            pokemon.Moves.Add(move);
            trainer.UseMove(0);

            if(trainer.TryGetMove(out var move2))
            {
                Assert.AreEqual(move2, move);
            }
            else
            {
                Assert.Fail("Expected a move to be locked in");
            }
        }


        private class MockMove : Move
        {

        }

        private class MockPokemon : Pokemon
        {
            new List<Move> Moves = new List<Move>();
            public MockPokemon(string name) : base(name)
            {
                
            }
        }
    }
}
