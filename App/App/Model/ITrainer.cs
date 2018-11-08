using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    interface ITrainer
    {
        /// <summary>
        /// Name of the character
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Lock in what move the trainer will order their pokemon to use next turn
        /// </summary>
        /// <param name="move">must be between 0 and the number of moves the pokemon possess</param>
        /// <returns>false if specified move cannot be used, or if the input is out of range</returns>
        bool UseMove(int move);
        /// <summary>
        /// An active pokemon, can be null, if null, cant use moves, wont be ready
        /// </summary>
        IPokemon ActivePokemon { get; set; }
        /// <summary>
        /// Is the trainer ready to engage in the next turn of pokemon combat
        /// True if a move has been locked in.
        /// </summary>
        bool Ready { get; }
        /// <summary>
        /// Selected move
        /// </summary>
        /// <param name="move">Selected Move</param>
        /// <returns>True if a move has been selected</returns>
        bool TryGetMove(out Move move);
    }
}
