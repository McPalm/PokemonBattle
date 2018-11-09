using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public interface IPokemon
    {
        /// <summary>
        /// List of the pokemons available moves
        /// </summary>
        List<IMove> Moves { get; }

        /// <summary>
        /// Name of teh pokemon, needs to be bewteen 1 and 10 characters
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Current health the pokemon has, defaults to full health (max health)
        /// </summary>
        int Health { get; }
        /// <summary>
        /// Invoked whenever the current health on the pokemon changes
        /// </summary>
        Action<int> OnHealthChange { get; set; }
        /// <summary>
        /// apply hitpoint damage to the pokemon, cannot reduce pokemon below 0, 
        /// </summary>
        /// <param name="dmg"></param>
        void Hurt(int dmg);
        /// <summary>
        /// Restore hitpoints on the pokemon, will not increase above 
        /// </summary>
        /// <param name="heal"></param>
        void Heal(int heal);

        /// <summary>
        /// Use the given move on the given pokemon
        /// </summary>
        /// <param name="move">must be one of the pokemons moves, if not, return false</param>
        /// <param name="target"></param>
        /// <returns>false if the move fails for some reason</returns>
        bool UseMove(IMove move, IPokemon target);

        /// <summary>
        /// invoked when the pokemons is knocked out (reaches 0)
        /// </summary>
        Action OnKnockout { get; set; }

        ///
        /// All attributes default to 5
        /// Attributes cannot go below 1

        int MaxHealth { get; set; }
        int Attack { get; set; }
        int Defence { get; set; }
        int SpAttack { get; set; }
        int SpDefence { get; set; }
        int Speed { get; set; }

        bool CanAct { get; }
        bool KnockedOut { get; }
    }
}
