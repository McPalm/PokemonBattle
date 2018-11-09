using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Trainer : ITrainer
    {
        private int pickedMove = -1;

        public string Name { get; set; }
        public IPokemon ActivePokemon { get; set; }

        public bool Ready { private set; get; }

        public bool TryGetMove(out IMove move)
        {
            if(Ready)
            {
                move = ActivePokemon?.Moves?[pickedMove];
                return move != null;
            }
            move = null;
            return false;
        }

        public bool UseMove(int move)
        {
            if (move < ActivePokemon.Moves.Count && move >= 0)
            {
                pickedMove = move;
                Ready = true;
                return true;
            }
            return false;
        }
    }
}
