using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    class Pokemon
    {
        public Pokemon(string name) => throw new NotImplementedException();

        /// <summary>
        /// List of the pokemons available moves
        /// </summary>
        public List<Move> Moves { get; private set; }

        /// <summary>
        /// Name of teh pokemon, needs to be bewteen 1 and 10 characters
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Current health the pokemon has, defaults to full health (max health)
        /// </summary>
        public int Health { get; private set; }
        /// <summary>
        /// Invoked whenever the current health on the pokemon changes
        /// </summary>
        public Action<int> OnHealthChange { get; set; }
        /// <summary>
        /// apply hitpoint damage to the pokemon, cannot reduce pokemon below 0, 
        /// </summary>
        /// <param name="dmg"></param>
        public void Hurt(int dmg) =>  throw new NotImplementedException();
        /// <summary>
        /// Restore hitpoints on the pokemon, will not increase above 
        /// </summary>
        /// <param name="heal"></param>
        public void Heal(int heal) => throw new NotImplementedException();

        /// <summary>
        /// Use the given move on the given pokemon
        /// </summary>
        /// <param name="move">must be one of the pokemons moves, if not, return false</param>
        /// <param name="target"></param>
        /// <returns>false if the move fails for some reason</returns>
        public bool UseMove(Move move, Pokemon target) => throw new NotImplementedException();

        /// <summary>
        /// invoked when the pokemons is knocked out (reaches 0)
        /// </summary>
        public Action OnKnockout { get; set; }

        ///
        /// All attributes default to 5
        
        public int MaxHealth { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int SpAttack { get; set; }
        public int SpDefence { get; set; }
        public int Speed { get; set; }

        public bool CanAct { get => true; }
        public bool KnockedOut { get => true; }
    }
}
