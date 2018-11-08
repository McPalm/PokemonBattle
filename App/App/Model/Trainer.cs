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

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IPokemon ActivePokemon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Ready => throw new NotImplementedException();

        public bool TryGetMove(out Move move)
        {
            throw new NotImplementedException();
        }

        public bool UseMove(int move)
        {
            if (move < ActivePokemon.Moves.Count && move > 0)
            {
                pickedMove = move;
                return true;
            }
            return false;
        }
    }
}
