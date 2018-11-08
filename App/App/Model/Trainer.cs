using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Trainer
    {
        /// <summary>
        /// Name of the character
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Lock in what move the trainer will order their pokemon to use next turn
        /// </summary>
        /// <param name="move">must be between 0 and the number of moves the pokemon possess</param>
        /// <returns>false if specified move cannot be used, or if the input is out of range</returns>
        public bool UseMove(int move) => throw new NotImplementedException();
        /// <summary>
        /// An active pokemon, can be null, if null, cant use moves, wont be ready
        /// </summary>
        public Pokemon ActivePokemon { get; set; }
        /// <summary>
        /// Is the trainer ready to engage in the next turn of pokemon combat
        /// True if a move has been locked in.
        /// </summary>
        public bool Ready { private set; get; }
        /// <summary>
        /// New instance of a trainer
        /// </summary>
        /// <param name="name">name of trainer</param>
        public Trainer(string name) => Name = name;
        /// <summary>
        /// Selected move
        /// </summary>
        /// <param name="move">Selected Move</param>
        /// <returns>True if a move has been selected</returns>
        public virtual bool TryGetMove(out Move move) => throw new NotImplementedException();
    }
}
