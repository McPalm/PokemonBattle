using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    class AI : Trainer
    {
        public AI(string name) : base(name) { }
        /// <summary>
        /// AI picks an appropiate move to use.
        /// As long as the state allows it, should always return a move.
        /// For the sake of testing, will return a random move on the pokemon it controls.
        /// </summary>
        /// <param name="move"></param>
        /// <returns></returns>
        public override bool TryGetMove(out Move move) => throw new NotImplementedException();
    }
}
