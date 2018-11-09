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

        [TestMethod]
        public void FaultyAttributesTest()
        {
            var pokemon = new Pokemon()
            {
                MaxHealth = -1,
                Attack = 0,
                Defence = -6,
                SpAttack = -7,
                SpDefence = 0,
                Speed = -168745,
            };
            Assert.IsTrue(pokemon.MaxHealth > 0);
            Assert.IsTrue(pokemon.Attack > 0);
            Assert.IsTrue(pokemon.Defence > 0);
            Assert.IsTrue(pokemon.SpAttack > 0);
            Assert.IsTrue(pokemon.SpDefence > 0);
            Assert.IsTrue(pokemon.Speed > 0);
        }

        // assert that the pokemons name is alwyas between 1 and 10 characters long
        [TestMethod]
        public void NameTest()
        {
            Predicate<string> validName = s => s.Length > 0 && s.Length <= 10;

            Pokemon pokemon = new Pokemon();

            if (validName(pokemon.Name) == false)
                Assert.Fail("Pokemon should have a valid name on creation");
            pokemon.Name = "01234567890";
            if (validName(pokemon.Name) == false)
                Assert.Fail("Pokemon should not accept names that are too long");
            pokemon.Name = "";
            if (validName(pokemon.Name) == false)
                Assert.Fail("Pokemon should not accept names that are too short");

            var expected = "bulbasaur";
            pokemon.Name = expected;
            Assert.AreEqual(pokemon.Name, expected);

            expected = "tauros";
            pokemon.Name = expected;
            Assert.AreEqual(pokemon.Name, expected);
        }

        // test that current health starts at full
        [TestMethod]
        public void StartHealthMax()
        {
            Pokemon pokemon = new Pokemon();
            Assert.AreEqual(pokemon.Health, pokemon.MaxHealth);
        }

        // est that current health floors at 0
        [TestMethod]
        public void HurtPokemon()
        {
            var pokemon = new Pokemon()
            {
                MaxHealth = 5,
            };

            pokemon.Hurt(2);
            Assert.AreEqual(pokemon.Health, 3);

            pokemon.Hurt(2);
            Assert.AreEqual(pokemon.Health, 1);

            pokemon.Hurt(2);
            Assert.AreEqual(pokemon.Health, 0);
        }

        // test thyat current health ceils at max health
        [TestMethod]
        public void HealPokemon()
        {
            var pokemon = new Pokemon()
            {
                MaxHealth = 5,
            };

            pokemon.Heal(2);
            Assert.AreEqual(pokemon.Health, 5);

            pokemon.Hurt(3);
            Assert.AreEqual(pokemon.Health, 2);

            pokemon.Heal(2);
            Assert.AreEqual(pokemon.Health, 4);

            pokemon.Heal(2);
            Assert.AreEqual(pokemon.Health, 5);
        }

        // test UseMove

        // test that we can add and remove move

        // test the OnKnockoutEvent

        // test the OnHealthChangeEvent

        // test so that if we change max health, current health stays at full

        // assert that CanAct is false when KnockedOut

        // assert that KnockedOut is true when health is 0
    }
}
