using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Model;
using Moq;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class PokemonTests
    {
        [TestMethod]
        public void AttributesTest()
        {
            Pokemon pokemon = new Pokemon();
            Assert.AreEqual(pokemon.MaxHealth, 5);
            Assert.AreEqual(pokemon.Attack, 5);
            Assert.AreEqual(pokemon.Defence, 5);
            Assert.AreEqual(pokemon.SpAttack, 5);
            Assert.AreEqual(pokemon.SpDefence, 5);
            Assert.AreEqual(pokemon.Speed, 5);

            pokemon = new Pokemon()
            {
                MaxHealth = 10,
                Attack = 11,
                Defence = 12,
                SpAttack = 13,
                SpDefence = 14,
                Speed = 15,
            };
            Assert.AreEqual(pokemon.MaxHealth, 10);
            Assert.AreEqual(pokemon.Attack, 11);
            Assert.AreEqual(pokemon.Defence, 12);
            Assert.AreEqual(pokemon.SpAttack, 13);
            Assert.AreEqual(pokemon.SpDefence, 14);
            Assert.AreEqual(pokemon.Speed, 15);
        }

        

        // test that current health starts at full

        // est that current health floors at 0

        // test thyat current health ceils at max health

        // test UseMove

        // test that we can add and remove move

        // test the OnKnockoutEvent

        // test the OnHealthChangeEvent

        // test so that if we change max health, current health stays at full

        // assert that CanAct is false when KnockedOut

        // assert that KnockedOut is true when health is 0
    }
}
